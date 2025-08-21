namespace HarpEngine;

public sealed class Scene
{
	// General
	private List<Entity> entitiesToAdd = new();
	private List<Entity> entities = new();
	private HashSet<Entity> entitiesToRemove = new();

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
