namespace HarpEngine;

public abstract class Camera : Entity
{
	public Camera(Scene scene, bool isActive = true) : base(scene)
	{
		if (isActive) scene.Camera = this;
	}

	internal abstract void Begin();
	internal abstract void End();
}
