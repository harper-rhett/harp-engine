namespace HarpEngine.Utilities;

public class FireTimer : Entity
{
	private float timeCooldown;
	private float backloggedTime;
	public Action Fired;

	public FireTimer(Scene scene, float timeCooldown) : base(scene)
	{
		this.timeCooldown = timeCooldown;
	}

	public override void Update(float frameTime)
	{
		backloggedTime += frameTime;
		int backloggedActions = (int)MathF.Floor(backloggedTime / timeCooldown);
		backloggedTime -= backloggedActions * timeCooldown;

		for (int actionNumber = 1; actionNumber <= backloggedActions; actionNumber++) Fired();
	}

	public override void Draw() { }
}

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
			scene.RemoveEntity(this);
		}
	}

	public override void Draw() { }
}