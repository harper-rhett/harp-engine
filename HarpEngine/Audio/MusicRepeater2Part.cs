namespace HarpEngine.Audio;

public class MusicRepeater2Part : Entity
{
	private Music initialMusic;
	private float initialMusicDuration;
	private float initialMusicEndTime;
	private float timePlayed;

	private Music repeatedMusic;

	private bool isStarted;
	private bool isPaused;
	private bool playingInitial;

	public MusicRepeater2Part(Scene scene, Music initialMusic, Music repeatedMusic) : base(scene)
	{
		this.initialMusic = initialMusic;
		initialMusicDuration = initialMusic.Duration;
		this.repeatedMusic = repeatedMusic;
	}

	public override void Update()
	{
		if (isStarted && !isPaused)
		{
			timePlayed += Engine.FrameTime;
			bool wasPlayingInitial = playingInitial;
			playingInitial = timePlayed <= initialMusicEndTime;
			if (wasPlayingInitial != playingInitial) repeatedMusic.Play();
			if (playingInitial) initialMusic.Update();
			else repeatedMusic.Update();
		}
	}

	public void Start()
	{
		initialMusic.Play();
		initialMusicEndTime = timePlayed + initialMusicDuration;
		isStarted = true;
	}

	public void Stop()
	{
		if (playingInitial) initialMusic.Stop();
		else repeatedMusic.Stop();
		isStarted = false;
	}

	public void Pause()
	{
		if (playingInitial) initialMusic.Pause();
		else repeatedMusic.Pause();
		isPaused = true;
	}

	public void Resume()
	{
		if (playingInitial) initialMusic.Resume();
		else repeatedMusic.Resume();
		isPaused = false;
	}
}
