using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarpEngine;

public sealed class Environment
{
	private List<Entity> entitiesToAdd = new();
	private List<Entity> entities = new();
	private HashSet<Entity> entitiesToRemove = new();

	public void Update(float frameTime)
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

	public void AddEntity(Entity entity) => entitiesToAdd.Add(entity);
	public void RemoveEntity(Entity entity) => entitiesToRemove.Add(entity);
}
