namespace HarpEngine;

public static class Graphics
{
	public static void ClearBackground(Color color)
	{
		Raylib.ClearBackground(color);
	}

	public static void DrawPixel(int x, int y, Color color)
	{
		Raylib.DrawPixel(x, y, color);
	}

	public static void DrawPixel(Vector2 position, Color color)
	{
		Raylib.DrawPixelV(position, color);
	}

	public static void DrawPolygon(Vector2 position, int sides, float radius, float rotation, Color color)
	{
		Raylib.DrawPoly(position, sides, radius, rotation, color);
	}

	public static void DrawPolygonLines(Vector2 position, int sides, float radius, float rotation, Color color)
	{
		Raylib.DrawPolyLines(position, sides, radius, rotation, color);
	}

	public static void DrawPolygonLines(Vector2 position, int sides, float radius, float rotation, float lineThickness, Color color)
	{
		Raylib.DrawPolyLinesEx(position, sides, radius, rotation, lineThickness, color);
	}
}
