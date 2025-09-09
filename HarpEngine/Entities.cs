using System.Collections;

namespace HarpEngine;

public class Entities
{
	// Entities
	private List<EntityToAdd> entitiesToAdd = new();
	private HashSet<Entity> entitiesToRemove = new();

	// Layers
	private SortedList<int, List<Entity>> updateLayers = new();
	private Dictionary<Entity, int> entityUpdateLayers = new();
	private SortedList<int, List<Entity>> drawLayers = new();
	private Dictionary<Entity, int> entityDrawLayers = new();

	// Registry
	private Dictionary<Type, object> entityLists = new();
	private Dictionary<Type, Entity> latestEntities = new();

	// Interface
	public int NextUpdateLayer;
	public int NextDrawLayer;

	private struct EntityToAdd
	{
		public Entity Entity;
		public int UpdateLayer;
		public int DrawLayer;
	}

	internal void Add(Entity entity)
	{
		EntityToAdd entityToInsert = new()
		{
			Entity = entity,
			UpdateLayer = NextUpdateLayer,
			DrawLayer = NextDrawLayer
		};
		NextUpdateLayer = 0;
		NextDrawLayer = 0;
		entitiesToAdd.Add(entityToInsert);
		Register(entity);
	}

	internal void Remove(Entity entity)
	{
		entity.OnRemove();
		entitiesToRemove.Add(entity);
		Unregister(entity);
	}

	internal void ProcessAdditions()
	{
		foreach (EntityToAdd entityToAdd in entitiesToAdd)
		{
			AddToUpdateLayer(entityToAdd);
			AddToDrawLayer(entityToAdd);
		}
		entitiesToAdd.Clear();
	}

	private void AddToUpdateLayer(EntityToAdd entityToAdd)
	{
		bool layerExists = updateLayers.TryGetValue(entityToAdd.UpdateLayer, out List<Entity> updateLayer);
		if (!layerExists)
		{
			updateLayer = new();
			updateLayers[entityToAdd.UpdateLayer] = updateLayer;
		}
		entityUpdateLayers[entityToAdd.Entity] = entityToAdd.UpdateLayer;
		updateLayer.Add(entityToAdd.Entity);
	}

	private void AddToDrawLayer(EntityToAdd entityToAdd)
	{
		bool layerExists = drawLayers.TryGetValue(entityToAdd.DrawLayer, out List<Entity> drawLayer);
		if (!layerExists)
		{
			drawLayer = new();
			drawLayers[entityToAdd.DrawLayer] = drawLayer;
		}
		entityDrawLayers[entityToAdd.Entity] = entityToAdd.DrawLayer;
		drawLayer.Add(entityToAdd.Entity);
	}

	internal void ProcessRemovals()
	{
		foreach (Entity entityToRemove in entitiesToRemove)
		{
			int updateLayer = entityUpdateLayers[entityToRemove];
			entityUpdateLayers.Remove(entityToRemove);
			updateLayers[updateLayer].Remove(entityToRemove);

			int drawLayer = entityDrawLayers[entityToRemove];
			entityDrawLayers.Remove(entityToRemove);
			drawLayers[drawLayer].Remove(entityToRemove);
		}
		entitiesToRemove.Clear();
	}

	internal void Register(Entity entity)
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

	internal void Unregister(Entity entity)
	{
		Type type = entity.GetType();
		object entityListObject = entityLists[type];
		IList entityList = (IList)entityListObject;
		entityList.Remove(entity);
		if (entityList.Count > 0) latestEntities[type] = (Entity)entityList[entityList.Count - 1];
		else latestEntities.Remove(type);
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

	public void DrawDebug(int fontSize, int spacing)
	{
		int index = 0;
		foreach (KeyValuePair<Type, object> entityListPair in entityLists)
		{
			// Get type
			Type type = entityListPair.Key;
			string typeString = type.ToString();

			// Convert to list
			IList entityList = (IList)entityListPair.Value;
			int typeCount = entityList.Count;
			if (typeCount == 0) continue;

			// Draw type
			string text = $"{typeString}: {typeCount}";
			int y = spacing + index * (fontSize + spacing);
			Text.Draw(text, spacing, y, fontSize, Colors.White);
			index++;
		}
	}

	public IEnumerable<Entity> InUpdateOrder
	{
		get
		{
			foreach (List<Entity> entityLayer in updateLayers.Values)
				foreach (Entity entity in entityLayer)
					yield return entity;
		}
	}

	public IEnumerable<Entity> InDrawOrder
	{
		get
		{
			foreach (List<Entity> entityLayer in drawLayers.Values)
				foreach (Entity entity in entityLayer)
					yield return entity;
		}
	}
}
