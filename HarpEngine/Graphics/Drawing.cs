namespace HarpEngine.Graphics;

public static class Drawing
{
	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void ClearBackground(Color color);
	public static void Clear(Color color) => ClearBackground(color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void BeginDrawing();
	public static void Begin() => BeginDrawing();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void EndDrawing();
	public static void End() => EndDrawing();
}
