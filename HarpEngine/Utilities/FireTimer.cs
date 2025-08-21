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

		foreach (int actionCount in Enumerable.Range(0, backloggedActions)) Fired();
	}

	public override void Draw() { }
}
