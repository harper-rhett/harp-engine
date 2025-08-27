namespace HarpEngine.Easing;

public class Easer : Entity
{
	// General
	private float startTime;
	private float finishTime;
	private float easeTime;

	// Interface
	public delegate float CurveFunction(float valueToCurve);
	public CurveFunction Curve = Curves.Linear;
	public Action Finished;
	public bool IsEasing { get; private set; }
	public float Progress { get; private set; }
	public float CurveProgress { get; private set; }
	public bool RemoveOnFinish = true;

	public Easer(Scene scene, float easeTime) : base(scene)
	{
		this.easeTime = easeTime;
	}

	public override void Update(float frameTime)
	{
		if (!IsEasing) return;

		if (scene.Time < finishTime) Ease();
		else Finish();
	}

	public override void Draw() { }

	private void Ease()
	{
		Progress = (scene.Time - startTime) / easeTime;
		CurveProgress = Curve(Progress);
	}

	public void Start()
	{
		startTime = scene.Time;
		finishTime = startTime + easeTime;
		IsEasing = true;
	}

	private void Finish()
	{
		IsEasing = false;
		Finished?.Invoke();
		Remove();
	}

	public float EaseFloat(float from, float to)
	{
		return float.Lerp(from, to, CurveProgress);
	}

	public Vector2 EaseVector2(Vector2 from, Vector2 to)
	{
		return Vector2.Lerp(from, to, CurveProgress);
	}

	public Vector3 EaseVector3(Vector3 from, Vector3 to)
	{
		return Vector3.Lerp(from, to, CurveProgress);
	}

	public Quaternion EaseQuaternion(Quaternion from, Quaternion to)
	{
		return Quaternion.Lerp(from, to, CurveProgress);
	}
}