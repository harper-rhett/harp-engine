namespace HarpEngine.Audio;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct Music : IDisposable
{
	public AudioStream Stream;
	public uint FrameCount;
	private byte looping;
	public bool Looping
	{
		get => looping != 0;
		set => looping = (byte)(value ? 1 : 0);
	}
	public int CtxType;
	public void* CtxData;

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern Music LoadMusicStream(string filePath);
	public static Music Load(string filePath) => LoadMusicStream(filePath);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern bool IsMusicValid(Music music);
	public bool IsValid => IsMusicValid(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void UnloadMusicStream(Music music);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void PlayMusicStream(Music music);
	public void Play() => PlayMusicStream(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern bool IsMusicStreamPlaying(Music music);
	public bool IsPlaying => IsMusicStreamPlaying(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void UpdateMusicStream(Music music);
	public void Update() => UpdateMusicStream(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void StopMusicStream(Music music);
	public void Stop() => StopMusicStream(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void PauseMusicStream(Music music);
	public void Pause() => PauseMusicStream(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void ResumeMusicStream(Music music);
	public void Resume() => ResumeMusicStream(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void SeekMusicStream(Music music, float seconds);
	public float Position { set => SeekMusicStream(this, value); }

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void SetMusicVolume(Music music, float volume);
	public float Volume { set => SetMusicVolume(this, value); }

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void SetMusicPitch(Music music, float pitch);
	public float Pitch { set => SetMusicPitch(this, value); }

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void SetMusicPan(Music music, float pan);
	public float StereoPan { set => SetMusicPan(this, value); }

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern float GetMusicTimeLength(Music music);
	public float Duration => GetMusicTimeLength(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern float GetMusicTimePlayed(Music music);
	public float TimePlayed => GetMusicTimePlayed(this);

	public void Dispose()
	{
		UnloadMusicStream(this);
	}
}
