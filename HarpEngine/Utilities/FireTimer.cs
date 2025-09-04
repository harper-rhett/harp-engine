namespace HarpEngine.Utilities;

public class FireTimer
{
	private float backloggedTime;
	public delegate void FiredDelegate();
	public event FiredDelegate Fired;

	public FireTimer()
	{
		Fired += OnFired;
	}

	public void Update(float frameTime, float cooldownTime)
	{
		backloggedTime += frameTime;
		int backloggedActions = (int)MathF.Floor(backloggedTime / cooldownTime);
		backloggedTime -= backloggedActions * cooldownTime;

		for (int actionNumber = 1; actionNumber <= backloggedActions; actionNumber++) Fired?.Invoke();
	}

	public virtual void OnFired() { }
}

public class FireTimerEntity : Entity
{
	private FireTimer fireTimer;
	private bool isStarted;
	public float CooldownTime;

	public event FireTimer.FiredDelegate Fired
	{
		add { fireTimer.Fired += value; }
		remove { fireTimer.Fired -= value; }
	}

	public FireTimerEntity(Scene scene, float cooldownTime) : base(scene)
	{
		CooldownTime = cooldownTime;
		fireTimer = new FireTimer();
		Fired += OnFired;
	}

	public override void Update(float frameTime)
	{
		if (isStarted) fireTimer.Update(frameTime, CooldownTime);
	}

	public void Start()
	{
		isStarted = true;
	}

	public virtual void OnFired() { }
}