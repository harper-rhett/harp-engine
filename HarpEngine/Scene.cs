using System.Collections;

namespace HarpEngine;

public class Scene
{
	// General
	private List<EntityToAdd> entitiesToAdd = new();
	private List<Entity> entities = new();
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
	public int NextEntityIndex = 0;

	public Scene()
	{
		Entities = entities.AsReadOnly();
		Camera = new();
	}

	public void Update(float frameTime)
	{
		if (IsPaused) return;
		Time += frameTime;

		UpdateEntities(frameTime);
		Camera.Update(frameTime);
	}

	private void UpdateEntities(float frameTime)
	{
		foreach (EntityToAdd entityToAdd in entitiesToAdd) entities.Insert(entityToAdd.Index, entityToAdd.Entity);
		entitiesToAdd.Clear();

		foreach (Entity entity in entities)
		{
			if (entity.IsUpdating) entity.Update(frameTime);
		}

		entities.RemoveAll(entitiesToRemove.Contains);
		entitiesToRemove.Clear();
	}

	public void Draw()
	{
		DrawGame();
		DrawGUI();
	}

	private void DrawGame()
	{
		Camera.Begin();
		foreach (Entity entity in entities)
		{
			if (entity.IsRendering) entity.Draw();
		}
		Camera.End();
	}

	private void DrawGUI()
	{
		foreach (Entity entity in entities)
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
			Index = NextEntityIndex
		};
		NextEntityIndex = entities.Count + entitiesToAdd.Count;
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
		public int Index;
	}
}
