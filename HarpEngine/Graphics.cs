namespace HarpEngine;

public static class Graphics
{
	// Background

	public static void ClearBackground(Color color)
	{
		Raylib.ClearBackground(color);
	}

	// Pixels

	public static void DrawPixel(int x, int y, Color color)
	{
		Raylib.DrawPixel(x, y, color);
	}

	public static void DrawPixel(Vector2 position, Color color)
	{
		Raylib.DrawPixelV(position, color);
	}

	// Circles

	public static void DrawCircle(int x, int y, float radius, Color color)
	{
		Raylib.DrawCircle(x, y, radius, color);
	}

	public static void DrawCircle(Vector2 position, float radius, Color color)
	{
		Raylib.DrawCircleV(position, radius, color);
	}

	public static void DrawCircleLines(int x, int y, float radius, Color color)
	{
		Raylib.DrawCircleLines(x, y, radius, color);
	}

	public static void DrawCircleLines(Vector2 position, float radius, Color color)
	{
		Raylib.DrawCircleLinesV(position, radius, color);
	}

	// Polygons

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
