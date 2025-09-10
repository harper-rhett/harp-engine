namespace HarpEngine.Audio;

[StructLayout(LayoutKind.Sequential)]
public struct AudioStream : IDisposable
{
	public IntPtr Buffer;
	public IntPtr Processor;
	public uint SampleRate;
	public uint SampleSize;
	public uint Channels;

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern bool IsAudioStreamValid(AudioStream audioStream);
	public bool IsValid => IsAudioStreamValid(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void UnloadAudioStream(AudioStream audioStream);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern bool IsAudioStreamProcessed(AudioStream audioStream);
	public bool IsProcessed => IsAudioStreamProcessed(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void PlayAudioStream(AudioStream audioStream);
	public void Play() => PlayAudioStream(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void PauseAudioStream(AudioStream audioStream);
	public void Pause() => PauseAudioStream(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void ResumeAudioStream(AudioStream audioStream);
	public void Resume() => ResumeAudioStream(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern bool IsAudioStreamPlaying(AudioStream audioStream);
	public bool IsPlaying => IsAudioStreamPlaying(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void StopAudioStream(AudioStream audioStream);
	public void Stop() => StopAudioStream(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void SetAudioStreamVolume(AudioStream audioStream, float volume);
	public float Volume { set => SetAudioStreamVolume(this, value); }

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void SetAudioStreamPitch(AudioStream audioStream, float pitch);
	public float Pitch { set => SetAudioStreamPitch(this, value); }

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void SetAudioStreamPan(AudioStream audioStream, float pan);
	public float StereoPan { set => SetAudioStreamPan(this, value); }

	public void Dispose()
	{
		UnloadAudioStream(this);
	}
}
