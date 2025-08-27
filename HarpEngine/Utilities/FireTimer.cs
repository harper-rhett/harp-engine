namespace HarpEngine.Utilities;

public sealed class FireTimer : Entity
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