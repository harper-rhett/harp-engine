using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarpEngine;

public sealed class Scene
{
	private List<Entity> entitiesToAdd = new();
	private List<Entity> entities = new();
	private List<Entity> entitiesToRemove = new();

	public void Update(float frameTime)
	{
		foreach (Entity entity in entitiesToAdd) entities.Add(entity);
		entitiesToAdd.Clear();

		foreach (Entity entity in entities) entity.Update(frameTime);

		foreach (Entity entity in entitiesToRemove) entities.Remove(entity);
		entitiesToRemove.Clear();
	}

	public void Draw()
	{
		foreach (Entity entity in entities) entity.Draw();
	}

	public void AddEntity(Entity entity) => entitiesToAdd.Add(entity);
	public void RemoveEntity(Entity entity) => entitiesToRemove.Add(entity);
}
