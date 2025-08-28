using System.Collections;

namespace HarpEngine;

public class Scene
{
	// General
	private List<EntityToAdd> entitiesToAdd = new();
	private SortedList<int, List<Entity>> updateLayers = new();
	private Dictionary<Entity, int> entityLayers = new();
	private HashSet<Entity> entitiesToRemove = new();
	private Dictionary<Type, object> entityLists = new();
	private Dictionary<Type, Entity> latestEntities = new();

	// Interface
	public IReadOnlyList<Entity> Entities;
	public Camera Camera;
	/// <summary>Seconds since creation that this world has been unpaused.</summary>
	public float Time { get; private set; }
	/// <summary>If the update loop is paused. The draw loop is unaffected/</summary>
	public bool IsPaused;
	public int NextEntityUpdateLayer = 0;

	public Scene()
	{
		Entities = entityLayers.Keys.ToList().AsReadOnly();
		Camera = new();
	}

	public void Update(float frameTime)
	{
		if (IsPaused) return;
		Time += frameTime;

		AddEntities();
		RemoveEntities();
		UpdateEntities(frameTime);
		Camera.Update(frameTime);
	}

	private void AddEntities()
	{
		foreach (EntityToAdd entityToAdd in entitiesToAdd)
		{
			bool layerExists = updateLayers.TryGetValue(entityToAdd.UpdateLayer, out List<Entity> updateLayer);
			if (layerExists) updateLayer.Add(entityToAdd.Entity);
			else
			{
				updateLayer = new();
				updateLayers[entityToAdd.UpdateLayer] = updateLayer;
			}
			entityLayers[entityToAdd.Entity] = entityToAdd.UpdateLayer;
			updateLayer.Add(entityToAdd.Entity);
		}
		entitiesToAdd.Clear();
	}

	private void RemoveEntities()
	{
		foreach (Entity entityToRemove in entitiesToRemove)
		{
			int updateLayer = entityLayers[entityToRemove];
			updateLayers[updateLayer].Remove(entityToRemove);
		}
		entitiesToRemove.Clear();
	}

	private void UpdateEntities(float frameTime)
	{
		// I should probably make this class enumerable so that it can be looped through in this manner more easily
		foreach (List<Entity> entityLayer in updateLayers.Values)
			foreach (Entity entity in entityLayer)
			{
				if (entity.IsUpdating) entity.Update(frameTime);
			}
	}

	public void Draw()
	{
		DrawGame();
		DrawGUI();
	}

	private void DrawGame()
	{
		Camera.Begin();
		foreach (List<Entity> entityLayer in updateLayers.Values)
			foreach (Entity entity in entityLayer)
			{
				if (entity.IsRendering) entity.Draw();
			}
		Camera.End();
	}

	private void DrawGUI()
	{
		foreach (List<Entity> entityLayer in updateLayers.Values)
			foreach (Entity entity in entityLayer)
			{
				if (entity.IsRendering) entity.DrawGUI();
			}
	}

	private void RegisterEntity(Entity entity)
	{
		// Get the entity list
		Type type = entity.GetType();
		bool setExists = entityLists.TryGetValue(type, out object entityListObject);

		// Register as latest
		latestEntities[type] = entity;

		// Create list if needed
		if (!setExists)
		{
			Type listType = typeof(List<>).MakeGenericType(type);
			entityListObject = (IList)Activator.CreateInstance(listType);
			entityLists[type] = entityListObject;
		}

		// Add entity to list
		((IList)entityListObject).Add(entity);
	}

	public IReadOnlyList<EntityType> GetEntities<EntityType>() where EntityType : Entity
	{
		// Get the entity list
		Type type = typeof(EntityType);
		bool setExists = entityLists.TryGetValue(type, out object entityListObject);

		// Return
		if (setExists) return (List<EntityType>)entityListObject;
		else return Array.Empty<EntityType>();
	}

	public EntityType GetEntity<EntityType>() where EntityType : Entity
	{
		Type type = typeof(EntityType);
		return (EntityType)latestEntities[type];
	}

	internal void AddEntity(Entity entity)
	{
		EntityToAdd entityToInsert = new()
		{
			Entity = entity,
			UpdateLayer = NextEntityUpdateLayer
		};
		NextEntityUpdateLayer = 0;
		entitiesToAdd.Add(entityToInsert);
		RegisterEntity(entity);
	}

	internal void RemoveEntity(Entity entity)
	{
		entity.OnRemove();
		entitiesToRemove.Add(entity);
	}

	private struct EntityToAdd
	{
		public Entity Entity;
		public int UpdateLayer;
	}
}
