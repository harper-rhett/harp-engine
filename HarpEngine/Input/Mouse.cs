namespace HarpEngine.Input;

public static class Mouse
{
	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern bool IsMouseButtonPressed(MouseButton mouseButton);
	public static bool IsButtonPressed(MouseButton mouseButton) => IsMouseButtonPressed(mouseButton);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern bool IsMouseButtonDown(MouseButton mouseButton);
	public static bool IsButtonDown(MouseButton mouseButton) => IsMouseButtonDown(mouseButton);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern bool IsMouseButtonReleased(MouseButton mouseButton);
	public static bool IsButtonReleased(MouseButton mouseButton) => IsMouseButtonReleased(mouseButton);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern int GetMouseX();
	public static int WindowX => GetMouseX();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern int GetMouseY();
	public static int WindowY => GetMouseY();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern Vector2 GetMousePosition();
	public static Vector2 WindowPosition => GetMousePosition();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern Vector2 GetMouseDelta();
	public static Vector2 Delta => GetMouseDelta();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern float GetMouseWheelMove();
	public static float WheelDelta => GetMouseWheelMove();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void SetMouseCursor(MouseCursor mouseCursor);
	public static void SetCursor(MouseCursor mouseCursor) => SetMouseCursor(mouseCursor);
}
