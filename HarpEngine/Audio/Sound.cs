namespace HarpEngine.Audio;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct Sound : IDisposable
{
	public AudioStream Stream;
	public uint FrameCount;

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern Sound LoadSound(string filePath);
	public static Sound Load(string filePath) => LoadSound(filePath);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern bool IsSoundValid(Sound sound);
	public bool IsValid => IsSoundValid(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void UnloadSound(Sound sound);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void PlaySound(Sound sound);
	public void Play() => PlaySound(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void StopSound(Sound sound);
	public void Stop() => StopSound(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void PauseSound(Sound sound);
	public void Pause() => PauseSound(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void ResumeSound(Sound sound);
	public void Resume() => ResumeSound(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern bool IsSoundPlaying(Sound sound);
	public bool IsPlaying => IsSoundPlaying(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void SetSoundVolume(Sound sound, float volume);
	public float Volume { set => SetSoundVolume(this, value); }

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void SetSoundPitch(Sound sound, float pitch);
	public float Pitch { set => SetSoundPitch(this, value); }

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void SetSoundPan(Sound sound, float pan);
	public float StereoPan { set => SetSoundPan(this, value); }

	public void Dispose()
	{
		UnloadSound(this);
	}
}