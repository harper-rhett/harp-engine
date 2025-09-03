namespace HarpEngine.Input;

public static class Keyboard
{
	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern bool IsKeyPressed(KeyboardKey key);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern bool IsKeyRepeating(KeyboardKey key);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern bool IsKeyDown(KeyboardKey key);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern bool IsKeyReleased(KeyboardKey key);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern KeyboardKey GetKeyPressed();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern int GetCharPressed();
	public static int GetUnicodePressed() => GetCharPressed();
}
