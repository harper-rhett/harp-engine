namespace HarpEngine.Windowing;

public static class Window
{
	internal static WindowRenderer Renderer { get; private set; } = new BorderedRenderer(Color.Black);

	private enum WindowFlags : uint
	{
		VSync = 0x00000040,
		Fullscreen = 0x00000002,
		Resizable = 0x00000004,
		Undecorated = 0x00000008,
		Hidden = 0x00000080,
		Minimized = 0x00000200,
		Maximized = 0x00000400,
		Unfocused = 0x00000800,
		Topmost = 0x00001000,
		AlwaysRun = 0x00000100,
		Transparent = 0x00000010,
		HighDpi = 0x00002000,
		MousePassthrough = 0x00004000,
		Borderless = 0x00008000,
		MSAA4x = 0x00000020,
		Interlaced = 0x00010000,
	}

	public static void SetBordered(Color borderColor) => Renderer = new BorderedRenderer(borderColor);
	public static void SetClipped() => Renderer = new ClippedRenderer();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void InitWindow(int width, int height, string title);

	public static void Initialize(int width, int height, string title) => InitWindow(width, height, title);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern bool WindowShouldClose();

	internal static bool ShouldClose() => WindowShouldClose();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void SetWindowState(WindowFlags flags);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void ClearWindowState(WindowFlags flags);

	private static void SetState(WindowFlags flags, bool isEnabled)
	{
		if (isEnabled) SetWindowState(flags);
		else ClearWindowState(flags);
	}

	public static void SetResizable(bool isResizable) => SetState(WindowFlags.Resizable, isResizable);
	public static void SetMaximized(bool isMaximized) => SetState(WindowFlags.Maximized, isMaximized);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern int GetScreenWidth();
	public static int Width => GetScreenWidth();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern int GetScreenHeight();
	public static int Height => GetScreenHeight();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void SetExitKey(KeyboardKey key);
}
