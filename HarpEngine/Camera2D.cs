namespace HarpEngine;

public class Camera2D : Camera
{
	// General
	private RaylibCamera2D raylibCamera;
	public Transform2D Transform = new();

	// World space transitions
	private Vector2 originalWorldPosition;
	private Vector2 targetWorldPosition;
	private float originalWorldRotation;
	private float targetWorldRotation;

	// Local space transitions
	private Vector2 originalLocalPosition;
	private Vector2 targetLocalPosition;
	private float originalLocalRotation;
	private float targetLocalRotation;

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
		originalWorldPosition = Transform.WorldPosition;
		targetWorldPosition = targetPosition;

		Easer easer = new(scene, seconds);
		easer.Easing += EaseWorldPosition;
		easer.Start();
	}

	private void EaseWorldPosition(Easer easer)
	{
		Transform.WorldPosition = easer.EaseVector2(originalWorldPosition, targetWorldPosition);
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

	public void TransitionLocalPosition(Vector2 targetPosition, float seconds)
	{
		originalLocalPosition = Transform.LocalPosition;
		targetLocalPosition = targetPosition;

		Easer easer = new(scene, seconds);
		easer.Easing += EaseLocalPosition;
		easer.Start();
	}

	private void EaseLocalPosition(Easer easer)
	{
		Transform.LocalPosition = easer.EaseVector2(originalLocalPosition, targetLocalPosition);
	}

	public void TransitionLocalRotation(float targetRotation, float seconds)
	{
		originalLocalRotation = Transform.LocalRotation;
		targetLocalRotation = targetRotation;

		Easer easer = new(scene, seconds);
		easer.Easing += EaseLocalRotation;
		easer.Start();
	}

	private void EaseLocalRotation(Easer easer)
	{
		Transform.LocalRotation = easer.EaseFloat(originalLocalRotation, targetLocalRotation);
	}
}
