namespace HarpEngine.Utilities;

public class TriggerTimer : Entity
{
	private float triggerTime;
	private float startTime;
	private float endTime = float.MaxValue;
	private bool isTriggered;
	public bool RemoveOnTriggered = true;
	public delegate void TriggeredDelegate();
	public event TriggeredDelegate Triggered;

	public TriggerTimer(Scene scene, float triggerTime) : base(scene)
	{
		this.triggerTime = triggerTime;
	}

	public override void Update(float frameTime)
	{
		if (isTriggered) return;

		if (scene.Time >= endTime) Trigger();
	}

	public void Start()
	{
		startTime = scene.Time;
		endTime = startTime + triggerTime;
	}

	public void Restart()
	{
		isTriggered = false;
		Start();
	}

	private void Trigger()
	{
		isTriggered = true;
		Triggered?.Invoke();
		if (RemoveOnTriggered) Remove();
		OnTriggered();
	}

	public virtual void OnTriggered() { }
}