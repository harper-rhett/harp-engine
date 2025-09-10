namespace HarpEngine.Utilities;

public class TriggerTimer : Entity
{
	private float triggerSeconds;
	private float startTime;
	private float triggerTime = float.MaxValue;
	private bool isTriggered;
	public bool RemoveOnTriggered = true;
	public delegate void TriggeredDelegate();
	public event TriggeredDelegate Triggered;

	public TriggerTimer(Scene scene, float triggerSeconds) : base(scene)
	{
		this.triggerSeconds = triggerSeconds;
	}

	public override void Update(float frameTime)
	{
		if (isTriggered) return;

		if (scene.Time >= triggerTime) Trigger();
	}

	public void Start()
	{
		startTime = scene.Time;
		triggerTime = startTime + triggerSeconds;
		isTriggered = false;
	}

	public void Skip()
	{
		triggerTime = scene.Time;
	}

	protected void Trigger()
	{
		isTriggered = true;
		Triggered?.Invoke();
		if (RemoveOnTriggered) Remove();
		OnTriggered();
	}

	public virtual void OnTriggered() { }
}