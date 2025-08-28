namespace HarpEngine.Audio;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct Music
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

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	private static extern Music LoadMusicStream(string filePath);
	public static Music Load(string filePath) => LoadMusicStream(filePath);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern float GetMusicTimeLength(Music music);
	public float Duration => GetMusicTimeLength(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern float GetMusicTimePlayed(Music music);
	public float TimePlayed => GetMusicTimePlayed(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void PlayMusicStream(Music music);
	public void Play() => PlayMusicStream(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void StopMusicStream(Music music);
	public void Stop() => StopMusicStream(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void UpdateMusicStream(Music music);
	public void Update() => UpdateMusicStream(this);
}
