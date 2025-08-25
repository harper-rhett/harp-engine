namespace HarpEngine;

public class Scene
{
	// General
	private List<Entity> entitiesToAdd = new();
	private List<Entity> entities = new();
	private HashSet<Entity> entitiesToRemove = new();
	private Dictionary<Type, List<Entity>> entityReferences = new();

	// Interface
	public IReadOnlyList<Entity> Entities;
	/// <summary>Seconds since creation that this world has been unpaused.</summary>
	public float Time { get; private set; }
	/// <summary>If the update loop is paused. The draw loop is unaffected/</summary>
	public bool IsPaused;

	public Scene()
	{
		Entities = entities.AsReadOnly();
	}

	public void Update(float frameTime)
	{
		if (IsPaused) return;
		Time += frameTime;

		UpdateEntities(frameTime);
	}

	private void UpdateEntities(float frameTime)
	{
		entities.AddRange(entitiesToAdd);
		entitiesToAdd.Clear();

		foreach (Entity entity in entities) entity.Update(frameTime);

		entities.RemoveAll(entity => entitiesToRemove.Contains(entity));
		entitiesToRemove.Clear();
	}

	public void Draw()
	{
		foreach (Entity entity in entities) entity.Draw();
	}

	// not sure if happy with this system:

	//private void RegisterEntity<EntityType>(Entity entity) where EntityType : Entity
	//{
	//	Type type = typeof(EntityType);
	//	List<Entity> entityList;
	//	bool setExists = entityReferences.TryGetValue(type, out entityList);
	//	if (!setExists)
	//	{
	//		entityList = new();
	//		entityReferences[type] = entityList;
	//	}
	//	entityList.Add(entity);
	//}

	//public EntityType[] GetEntities<EntityType>()
	//{
	//	Type type = typeof(EntityType);
	//	bool setExists = entityReferences.TryGetValue(type, out List<Entity> entityList);
	//	if (setExists) return entityList.Cast<EntityType>().ToArray();
	//	else return Array.Empty<EntityType>();
	//}

	public void InsertEntity(Entity entity, int index)
	{
		entitiesToAdd.Insert(index, entity);
	}

	public void AddEntity(Entity entity)
	{
		entitiesToAdd.Add(entity);
	}

	public void RemoveEntity(Entity entity)
	{
		entity.OnRemove();
		entitiesToRemove.Add(entity);
	}
}
