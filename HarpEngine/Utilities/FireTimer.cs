namespace HarpEngine.Utilities;

public class FireTimer : Entity
{
	public float CooldownTime;
	private float backloggedTime;
	private bool isStarted;
	public delegate void FiredDelegate();
	public event FiredDelegate Fired;

	public FireTimer(Scene scene, float cooldownTime) : base(scene)
	{
		CooldownTime = cooldownTime;
	}

	public override void Update(float frameTime)
	{
		if (!isStarted) return;

		backloggedTime += frameTime;
		int backloggedActions = (int)MathF.Floor(backloggedTime / CooldownTime);
		backloggedTime -= backloggedActions * CooldownTime;

		for (int actionNumber = 1; actionNumber <= backloggedActions; actionNumber++) Fire();
	}

	public override void Draw() { }

	public void Start()
	{
		isStarted = true;
	}

	private void Fire()
	{
		OnFired();
		Fired?.Invoke();
	}

	protected virtual void OnFired() { }
}