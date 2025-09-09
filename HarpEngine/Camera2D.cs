namespace HarpEngine;

public class Camera2D : Camera
{
	// General
	private RaylibCamera2D raylibCamera;
	public Transform2D Transform;

	// Transitioning
	private Vector2 originalPosition;
	private Vector2 targetPosition;
	private float originalWorldRotation;
	private float targetWorldRotation;

	public Camera2D(Scene scene) : base(scene)
	{
		Vector2 centeredOffset = new(Engine.HalfGameWidth, Engine.HalfGameHeight);
		raylibCamera = new(centeredOffset, Vector2.Zero, 0, 1);
	}

	public override void Update(float frameTime)
	{
		raylibCamera.Target = Transform.WorldPosition;
		raylibCamera.Rotation = Transform.WorldRotation;
	}

	internal override void Begin()
	{
		RaylibCamera2D.BeginRendering(raylibCamera);
	}

	internal override void End()
	{
		RaylibCamera2D.EndRendering();
	}

	public void TransitionWorldPosition(Vector2 targetPosition, float seconds)
	{
		originalPosition = Transform.WorldPosition;
		this.targetPosition = targetPosition;

		Easer easer = new(scene, seconds);
		easer.Easing += EaseWorldPosition;
		easer.Start();
	}

	private void EaseWorldPosition(Easer easer)
	{
		Transform.WorldPosition = easer.EaseVector2(originalPosition, targetPosition);
	}

	public void TransitionWorldRotation(float targetRotation, float seconds)
	{
		originalWorldRotation = Transform.WorldRotation;
		targetWorldRotation = targetRotation;

		Easer easer = new(scene, seconds);
		easer.Easing += EaseWorldRotation;
		easer.Start();
	}

	private void EaseWorldRotation(Easer easer)
	{
		Transform.WorldRotation = easer.EaseFloat(originalWorldRotation, targetWorldRotation);
	}
}
