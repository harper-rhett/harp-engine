namespace HarpEngine.Animation;

public class Easer : Entity
{
	// General
	private float startTime;
	private float finishTime;
	private float easeSeconds;

	// Interface
	public Curve Curve = Curves.Linear;
	public delegate void EasingDelegate(Easer easer);
	public event EasingDelegate Easing;
	public delegate void FinishedDelegate();
	public event FinishedDelegate Finished;
	public bool IsEasing { get; private set; }
	public float Progress { get; private set; }
	public float CurveProgress { get; private set; }
	public bool RemoveOnFinished = true;
	public bool Rewind;

	public Easer(Scene scene, float easeSeconds) : base(scene)
	{
		this.easeSeconds = easeSeconds;
	}

	public override void Update()
	{
		if (!IsEasing) return;

		if (scene.Time < finishTime) Ease();
		else Finish();
	}

	public override void Draw() { }

	private void Ease()
	{
		Progress = (scene.Time - startTime) / easeSeconds;
		CurveProgress = Curve(Progress);
		if (Rewind) CurveProgress = float.Sin(CurveProgress * float.Pi);
		Easing?.Invoke(this);
		OnEasing();
	}

	protected virtual void OnEasing() { }

	public void Start()
	{
		startTime = scene.Time;
		finishTime = startTime + easeSeconds;
		IsEasing = true;
	}

	public void Skip()
	{
		finishTime = scene.Time;
	}

	private void Finish()
	{
		IsEasing = false;
		Finished?.Invoke();
		if (RemoveOnFinished) Remove();
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

	public Color EaseColor(Color from, Color to)
	{
		return Color.Lerp(from, to, CurveProgress);
	}
}