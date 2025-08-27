namespace HarpEngine.Graphics;

public static class Drawing
{
	// Background

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void ClearBackground(Color color);
	public static void Clear(Color color) => ClearBackground(color);

	// Drawing

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void BeginDrawing();
	public static void Begin() => BeginDrawing();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void EndDrawing();
	public static void End() => EndDrawing();

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

	// Polygons

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DrawPoly(Vector2 position, int sides, float radius, float rotation, Color color);
	public static void DrawPolygon(Vector2 position, int sides, float radius, float rotation, Color color) => DrawPoly(position, sides, radius, rotation, color);

	// Textures

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DrawTexturePro(Texture2D texture, Rectangle source, Rectangle dest, Vector2 origin, float rotation, Color tint);
	public static void DrawTexture(Texture2D texture, Rectangle source, Rectangle destination, Vector2 origin, float rotation, Color tint) => DrawTexturePro(texture, source, destination, origin, rotation, tint);
}
