namespace HarpEngine;

public class Camera2D : Camera
{
	// 2D
	private RaylibCamera2D raylibCamera;
	public Vector2 Position
	{
		get => raylibCamera.Target;
		set => raylibCamera.Target = value;
	}

	public Camera2D(Scene scene) : base(scene)
	{
		Vector2 centeredOffset = new(Engine.HalfGameWidth, Engine.HalfGameHeight);
		raylibCamera = new(centeredOffset, Vector2.Zero, 0, 1);
	}

	internal override void Begin()
	{
		RaylibCamera2D.BeginRendering(raylibCamera);
	}

	internal override void End()
	{
		RaylibCamera2D.EndRendering();
	}

	public void Transition(Vector2 targetPosition, float seconds)
	{
		Easer easer = new(scene, seconds);
	}
}
