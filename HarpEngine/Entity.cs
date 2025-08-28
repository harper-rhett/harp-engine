namespace HarpEngine;

public abstract class Entity
{
	protected Scene scene;
	public bool IsUpdating = true;
	public bool IsRendering = true;

	public Entity(Scene scene)
	{
		this.scene = scene;
		scene.Entities.Add(this);
	}

	public virtual void Update(float frameTime) { }
	public virtual void Draw() { }
	public virtual void DrawGUI() { }

	public void Remove()
	{
		scene.Entities.Remove(this);
	}

	public virtual void OnRemove() { }
}
