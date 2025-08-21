namespace HarpEngine;

public abstract class Entity
{
	protected Scene scene;

	public Entity(Scene scene)
	{
		this.scene = scene;
	}

	public abstract void Update(float frameTime);
	public abstract void Draw();
	public virtual void OnRemove() { }
}
