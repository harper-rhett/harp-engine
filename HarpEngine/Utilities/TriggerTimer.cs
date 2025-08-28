namespace HarpEngine.Utilities;

public sealed class TriggerTimer : Entity
{
	private float triggerTime;
	private float startTime;
	private float endTime = float.MaxValue;
	public Action Triggered;

	public TriggerTimer(Scene scene, float triggerTime) : base(scene)
	{
		this.triggerTime = triggerTime;
	}

	public void Start()
	{
		startTime = scene.Time;
		endTime = startTime + triggerTime;
	}

	public override void Update(float frameTime)
	{
		if (scene.Time >= endTime)
		{
			Triggered();
			Remove();
		}
	}

	public override void Draw() { }
}