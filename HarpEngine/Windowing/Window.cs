namespace HarpEngine.Windowing;

public unsafe static class Window
{
	internal static WindowRenderer Renderer { get; private set; } = new FullRenderer(Colors.Black);

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

	public static void SetFullRenderer(Color borderColor) => Renderer = new FullRenderer(borderColor);
	public static void SetClippedRenderer() => Renderer = new ClippedRenderer();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void InitWindow(int width, int height, string title);
	public static void Initialize(int width, int height, string title) => InitWindow(width, height, title);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void CloseWindow();
	public static void Close() => CloseWindow();

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

	public static void SetVsync(bool isEnabled) => SetState(WindowFlags.VSync, isEnabled);
	public static void SetFullscreen(bool isFullscreen) => SetState(WindowFlags.Fullscreen, isFullscreen);
	public static void SetResizable(bool isResizable) => SetState(WindowFlags.Resizable, isResizable);
	public static void SetUndecorated(bool isUndecorated) => SetState(WindowFlags.Undecorated, isUndecorated);
	public static void SetMinimized(bool isMinimized) => SetState(WindowFlags.Minimized, isMinimized);
	public static void SetMaximized(bool isMaximized) => SetState(WindowFlags.Maximized, isMaximized);
	public static void SetBorderless(bool isBorderless) => SetState(WindowFlags.Borderless, isBorderless);
	public static void SetMSAA4x(bool isEnabled) => SetState(WindowFlags.MSAA4x, isEnabled);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern int GetScreenWidth();
	public static int Width => GetScreenWidth();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern int GetScreenHeight();
	public static int Height => GetScreenHeight();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void SetWindowSize(int width, int height);
	public static void Resize(int width, int height) => SetWindowSize(width, height);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void SetWindowIcon(Image image);
	public static void SetIcon(Image image) => SetWindowIcon(image);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void SetWindowIcons(Image* images, int count);
	public static void SetIcons(Image* images, int count) => SetWindowIcons(images, count);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void SetWindowTitle(string title);
	public static void ChangeTitle(string title) => SetWindowTitle(title);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void SetWindowPosition(int x, int y);
	public static void SetPosition(int x, int y) => SetWindowPosition(x, y);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void SetWindowMonitor(int monitor);
	public static void SetMonitor(int monitor) => SetWindowMonitor(monitor);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void SetWindowFocused();
	public static void Focus() => SetWindowFocused();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern Vector2 GetWindowPosition();
	public static Vector2 Position => GetWindowPosition();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void SetExitKey(KeyboardKey key);
}
