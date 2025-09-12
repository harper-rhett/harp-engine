using System.Collections;

namespace HarpEngine;

public class Entities
{
	// Entities
	private List<Entity> entitiesToAdd = new();
	private List<Entity> entitiesToMoveUpdate = new();
	private List<Entity> entitiesToMoveDraw = new();
	private HashSet<Entity> entitiesToRemove = new();

	// Layers
	private SortedList<int, List<Entity>> updateLayers = new();
	private SortedList<int, List<Entity>> drawLayers = new();

	// Registry
	private Dictionary<Type, object> entityLists = new();
	private Dictionary<Type, Entity> latestEntities = new();

	// Interface
	public int NextUpdateLayer;
	public int NextDrawLayer;

	internal void Add(Entity entity)
	{
		entity.UpdateLayer = NextUpdateLayer;
		entity.DrawLayer = NextDrawLayer;
		NextUpdateLayer = 0;
		NextDrawLayer = 0;
		entitiesToAdd.Add(entity);
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
		foreach (Entity entity in entitiesToAdd)
		{
			AddToUpdateLayer(entity);
			AddToDrawLayer(entity);
		}
		entitiesToAdd.Clear();
	}

	internal void ProcessMoves()
	{
		foreach (Entity entity in entitiesToMoveUpdate)
		{
			updateLayers[entity.lastUpdateLayer].Remove(entity);
			updateLayers[entity.UpdateLayer].Add(entity);
		}
		entitiesToMoveUpdate.Clear();

		foreach (Entity entity in entitiesToMoveDraw)
		{
			drawLayers[entity.lastDrawLayer].Remove(entity);
			drawLayers[entity.DrawLayer].Add(entity);
		}
		entitiesToMoveDraw.Clear();
	}

	internal void ProcessRemovals()
	{
		foreach (Entity entity in entitiesToRemove)
		{
			updateLayers[entity.UpdateLayer].Remove(entity);
			drawLayers[entity.DrawLayer].Remove(entity);
		}
		entitiesToRemove.Clear();
	}

	private List<Entity> GetLayerEntities(SortedList<int, List<Entity>> layers, int layer)
	{
		bool layerExists = layers.TryGetValue(layer, out List<Entity> layerEntities);
		if (!layerExists)
		{
			layerEntities = new();
			layers[layer] = layerEntities;
		}
		return layerEntities;
	}

	private void AddToUpdateLayer(Entity entityToAdd)
	{
		List<Entity> updateLayerEntities = GetLayerEntities(updateLayers, entityToAdd.UpdateLayer);
		updateLayerEntities.Add(entityToAdd);
	}

	private void AddToDrawLayer(Entity entityToAdd)
	{
		List<Entity> drawLayerEntities = GetLayerEntities(drawLayers, entityToAdd.DrawLayer);
		drawLayerEntities.Add(entityToAdd);
	}

	public void MoveUpdateLayer(Entity entity)
	{
		entitiesToMoveUpdate.Add(entity);
	}

	public void MoveDrawLayer(Entity entity)
	{
		entitiesToMoveDraw.Add(entity);
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
