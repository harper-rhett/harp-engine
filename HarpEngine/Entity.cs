namespace HarpEngine;

public abstract class Entity
{
	protected Scene scene;
	public bool IsUpdating = true;
	public bool IsRendering = true;

	internal int lastUpdateLayer;
	private int updateLayer;
	public int UpdateLayer
	{
		get => updateLayer;
		set
		{
			lastUpdateLayer = updateLayer;
			updateLayer = value;
			scene.Entities.MoveUpdateLayer(this);
		}
	}
	internal int lastDrawLayer;
	private int drawLayer;
	public int DrawLayer
	{
		get => drawLayer;
		set
		{
			lastDrawLayer = drawLayer;
			drawLayer = value;
			scene.Entities.MoveDrawLayer(this);
		}
	}

	public Entity(Scene scene)
	{
		this.scene = scene;
		scene.Entities.Add(this);
	}

	public virtual void Update() { }
	public virtual void Draw() { }
	public virtual void DrawGUI() { }

	public void Remove()
	{
		scene.Entities.Remove(this);
	}

	public virtual void OnRemove() { }
}
