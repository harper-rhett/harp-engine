namespace HarpEngine.Audio;

public class MusicPlayer : Entity
{
	private Music music;
	private float musicDuration;
	private float endTime;
	private float timePlayed;

	private bool isStarted;
	public bool RemoveOnFinished = true;
	private bool isPaused;

	public MusicPlayer(Scene scene, Music music) : base(scene)
	{
		this.music = music;
		musicDuration = music.Duration;
	}

	public override void Update()
	{
		if (isStarted && !isPaused)
		{
			timePlayed += Engine.FrameTime;
			music.Update();
			if (timePlayed > endTime) Finish();
		}
	}

	public void Start()
	{
		music.Play();
		endTime = timePlayed + musicDuration;
		isStarted = true;
	}

	public void Stop()
	{
		music.Stop();
		isStarted = false;
	}

	public void Pause()
	{
		music.Pause();
		isPaused = true;
	}

	public void Resume()
	{
		music.Resume();
		isPaused = false;
	}

	private void Finish()
	{
		Stop();
		if (RemoveOnFinished) Remove();
	}
}
