namespace HarpEngine.Graphics;

public static class Primitives
{
	// Background

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void ClearBackground(Color color);
	public static void Clear(Color color) => ClearBackground(color);

	// Pixels

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void DrawPixel(int x, int y, Color color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void DrawPixelV(Vector2 position, Color color);
	public static void DrawPixel(Vector2 position, Color color) => DrawPixelV(position, color);

	// Circles

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void DrawCircle(int x, int y, float radius, Color color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DrawCircleV(Vector2 position, float radius, Color color);
	public static void DrawCircle(Vector2 position, float radius, Color color) => DrawCircleV(position, radius, color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void DrawCircleLines(int x, int y, float radius, Color color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DrawCircleLinesV(Vector2 position, float radius, Color color);
	public static void DrawCircleLines(Vector2 position, float radius, Color color) => DrawCircleLinesV(position, radius, color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void DrawRing(Vector2 center, float innerRadius, float outerRadius, float startAngle, float endAngle, int segments, Color color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void DrawRingLines(Vector2 center, float innerRadius, float outerRadius, float startAngle, float endAngle, int segments, Color color);

	// Polygons

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DrawPoly(Vector2 position, int sides, float radius, float rotation, Color color);
	public static void DrawPolygon(Vector2 position, int sides, float radius, float rotation, Color color) => DrawPoly(position, sides, radius, rotation, color);
}
