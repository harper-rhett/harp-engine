namespace HarpEngine.Utilities;

public class TriggerTimer : Entity
{
	private float triggerTime;
	private float startTime;
	public Action Triggered;

	public TriggerTimer(Scene scene, float triggerTime) : base(scene)
	{
		this.triggerTime = triggerTime;
		startTime = scene.Time;
	}

	public override void Update(float frameTime)
	{
		if (scene.Time >= startTime + triggerTime)
		{
			Triggered();
			Remove();
		}
	}

	public override void Draw() { }
}