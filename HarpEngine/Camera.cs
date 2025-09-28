namespace HarpEngine;

public abstract class Camera : Entity
{
	public Camera(Scene scene) : base(scene)
	{
		
	}

	internal abstract void Begin();
	internal abstract void End();
}
