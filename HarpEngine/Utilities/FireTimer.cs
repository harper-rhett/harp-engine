namespace HarpEngine.Utilities;

public class FireTimer : Entity
{
	private float timeCooldown;
	private float backloggedTime;
	private bool isStarted;
	public delegate void FiredDelegate();
	public event FiredDelegate Fired;

	public FireTimer(Scene scene, float timeCooldown) : base(scene)
	{
		this.timeCooldown = timeCooldown;
	}

	public override void Update(float frameTime)
	{
		if (!isStarted) return;

		backloggedTime += frameTime;
		int backloggedActions = (int)MathF.Floor(backloggedTime / timeCooldown);
		backloggedTime -= backloggedActions * timeCooldown;

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

	public virtual void OnFired() { }
}