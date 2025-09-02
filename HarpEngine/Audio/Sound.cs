namespace HarpEngine.Audio;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct Sound
{
	public AudioStream Stream;
	public uint FrameCount;

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern Sound LoadSound(string filePath);
	public static Sound Load(string filePath) => LoadSound(filePath);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void PlaySound(Sound sound);
	public void Play() => PlaySound(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void SetSoundVolume(Sound sound, float volume);
	public void SetVolume(float volume) => SetSoundVolume(this, volume);
}