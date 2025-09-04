namespace HarpEngine.Utilities;

public class FireTimer
{
	private float timeCooldown;
	private float backloggedTime;
	public delegate void FiredDelegate();
	public event FiredDelegate Fired;

	public FireTimer(float timeCooldown)
	{
		this.timeCooldown = timeCooldown;
		Fired += OnFired;
	}

	public void Update(float frameTime)
	{
		backloggedTime += frameTime;
		int backloggedActions = (int)MathF.Floor(backloggedTime / timeCooldown);
		backloggedTime -= backloggedActions * timeCooldown;

		for (int actionNumber = 1; actionNumber <= backloggedActions; actionNumber++) Fired?.Invoke();
	}

	public virtual void OnFired() { }
}

public class FireTimerEntity : Entity
{
	private FireTimer fireTimer;
	private bool isStarted;
	public event FireTimer.FiredDelegate Fired
	{
		add { fireTimer.Fired += value; }
		remove { fireTimer.Fired -= value; }
	}

	public FireTimerEntity(Scene scene, float timeCooldown) : base(scene)
	{
		fireTimer = new FireTimer(timeCooldown);
		Fired += OnFired;
	}

	public override void Update(float frameTime)
	{
		if (isStarted) fireTimer.Update(frameTime);
	}

	public void Start()
	{
		isStarted = true;
	}

	public virtual void OnFired() { }
}