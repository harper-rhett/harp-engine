namespace HarpEngine.Windowing;

internal class Cursor
{
	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void ShowCursor();
	public static void Show() => ShowCursor();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void HideCursor();
	public static void Hide() => HideCursor();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void EnableCursor();
	public static void Enable() => EnableCursor();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DisableCursor();
	public static void Disable() => DisableCursor();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern bool IsCursorOnScreen();
	public static bool IsOnScreen => IsCursorOnScreen();
}
