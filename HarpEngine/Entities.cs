using System.Collections;

namespace HarpEngine;

public class Entities : IEnumerable<Entity>
{
	// Entities
	private List<EntityToAdd> entitiesToAdd = new();
	private SortedList<int, List<Entity>> updateLayers = new();
	private Dictionary<Entity, int> entityLayers = new();
	private HashSet<Entity> entitiesToRemove = new();

	// Registry
	private Dictionary<Type, object> entityLists = new();
	private Dictionary<Type, Entity> latestEntities = new();

	// Interface
	public int NextUpdateLayer;

	private struct EntityToAdd
	{
		public Entity Entity;
		public int UpdateLayer;
	}

	internal void Add(Entity entity)
	{
		EntityToAdd entityToInsert = new()
		{
			Entity = entity,
			UpdateLayer = NextUpdateLayer
		};
		NextUpdateLayer = 0;
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

	internal void ProcessRemovals()
	{
		foreach (Entity entityToRemove in entitiesToRemove)
		{
			int updateLayer = entityLayers[entityToRemove];
			entityLayers.Remove(entityToRemove);
			updateLayers[updateLayer].Remove(entityToRemove);
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

	public IEnumerator<Entity> GetEnumerator()
	{
		foreach (List<Entity> entityLayer in updateLayers.Values)
			foreach (Entity entity in entityLayer)
				yield return entity;
	}

	IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
