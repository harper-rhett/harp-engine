namespace HarpEngine;

public abstract class Entity
{
	protected Scene scene;
	public bool IsUpdating = true;
	public bool IsRendering = true;

	public Entity(Scene scene)
	{
		this.scene = scene;
		scene.AddEntity(this);
	}

	public abstract void Update(float frameTime);
	public abstract void Draw();

	public void Remove()
	{
		scene.RemoveEntity(this);
	}

	public virtual void OnRemove() { }
}
