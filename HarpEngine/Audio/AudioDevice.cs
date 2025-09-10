namespace HarpEngine.Audio;

public static class AudioDevice
{
	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void InitAudioDevice();
	internal static void Initialize() => InitAudioDevice();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void CloseAudioDevice();
	internal static void Close() => CloseAudioDevice();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void SetMasterVolume(float volume);
	public static float Volume { set => SetMasterVolume(value); }

	public static void Restart()
	{
		Close();
		Initialize();
	}
}
