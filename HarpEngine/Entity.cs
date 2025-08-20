namespace HarpEngine;

public abstract class Entity
{
	public Environment World;

	public abstract void Update(float frameTime);
	public abstract void Draw();
	public virtual void OnRemove() { }
}
