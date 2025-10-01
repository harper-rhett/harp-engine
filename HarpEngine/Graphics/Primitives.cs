namespace HarpEngine.Graphics;

public static class Primitives
{
	// Pixels

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void DrawPixel(int x, int y, Color color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void DrawPixelV(Vector2 position, Color color);
	public static void DrawPixel(Vector2 position, Color color) => DrawPixelV(position, color);

	// Lines

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void DrawLine(int startX, int startY, int endX, int endY, Color color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DrawLineV(Vector2 startPosition, Vector2 endPosition, Color color);
	public static void DrawLine(Vector2 startPosition, Vector2 endPosition, Color color) => DrawLineV(startPosition, endPosition, color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DrawLineEx(Vector2 startPosition, Vector2 endPosition, float thickness, Color color);
	public static void DrawLine(Vector2 startPosition, Vector2 endPosition, float thickness, Color color) => DrawLineEx(startPosition, endPosition, thickness, color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DrawLineStrip(Vector2[] positions, int positionCount, Color color);
	public static void DrawLine(Vector2[] positions, Color color) => DrawLineStrip(positions, positions.Length, color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DrawLineBezier(Vector2 startPosition, Vector2 endPosition, float thickness, Color color);
	public static void DrawBezier(Vector2 startPosition, Vector2 endPosition, float thickness, Color color) => DrawLineBezier(startPosition, endPosition, thickness, color);

	// Circles

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void DrawCircle(int x, int y, float radius, Color color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DrawCircleSector(Vector2 position, float radius, float startAngle, float endAngle, int segments, Color color);
	public static void DrawArc(Vector2 position, float radius, float startAngle, float endAngle, int segments, Color color) => DrawCircleSector(position, radius, startAngle, endAngle, segments, color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DrawCircleSectorLines(Vector2 position, float radius, float startAngle, float endAngle, int segments, Color color);
	public static void DrawArcLines(Vector2 position, float radius, float startAngle, float endAngle, int segments, Color color) => DrawCircleSectorLines(position, radius, startAngle, endAngle, segments, color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DrawCircleGradient(int x, int y, float radius, Color innerColor, Color outerColor);
	public static void DrawCircle(int x, int y, float radius, Color innerColor, Color outerColor) => DrawCircleGradient(x, y, radius, innerColor, outerColor);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DrawCircleV(Vector2 position, float radius, Color color);
	public static void DrawCircle(Vector2 position, float radius, Color color) => DrawCircleV(position, radius, color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void DrawCircleLines(int x, int y, float radius, Color color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DrawCircleLinesV(Vector2 position, float radius, Color color);
	public static void DrawCircleLines(Vector2 position, float radius, Color color) => DrawCircleLinesV(position, radius, color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void DrawEllipse(int x, int y, float horizontalRadius, float verticalRadius, Color color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void DrawEllipseLines(int x, int y, float horizontalRadius, float verticalRadius, Color color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void DrawRing(Vector2 center, float innerRadius, float outerRadius, float startAngle, float endAngle, int segments, Color color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void DrawRingLines(Vector2 center, float innerRadius, float outerRadius, float startAngle, float endAngle, int segments, Color color);

	// Rectangles

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void DrawRectangle(int x, int y, int width, int height, Color color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DrawRectangleV(Vector2 position, Vector2 size, Color color);
	public static void DrawRectangle(Vector2 position, Vector2 size, Color color) => DrawRectangleV(position, size, color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DrawRectangleRec(Rectangle rectangle, Color color);
	public static void DrawRectangle(Rectangle rectangle, Color color) => DrawRectangleRec(rectangle, color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DrawRectanglePro(Rectangle rectangle, Vector2 origin, float rotation, Color color);
	public static void DrawRectangle(Rectangle rectangle, Vector2 origin, float rotation, Color color) => DrawRectanglePro(rectangle, origin, rotation, color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DrawRectangleGradientV(int x, int y, int width, int height, Color topColor, Color bottomColor);
	public static void DrawRectangleGradientVertical(int x, int y, int width, int height, Color topColor, Color bottomColor) => DrawRectangleGradientV(x, y, width, height, topColor, bottomColor);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DrawRectangleGradientH(int x, int y, int width, int height, Color leftColor, Color rightColor);
	public static void DrawRectangleGradientHorizontal(int x, int y, int width, int height, Color leftColor, Color rightColor) => DrawRectangleGradientH(x, y, width, height, leftColor, rightColor);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DrawRectangleGradientEx(Rectangle rectangle, Color topLeftColor, Color bottomLeftColor, Color topRightColor, Color bottomRightColor);
	public static void DrawRectangleGradient(Rectangle rectangle, Color topLeftColor, Color bottomLeftColor, Color topRightColor, Color bottomRightColor) => DrawRectangleGradient(rectangle, topLeftColor, bottomLeftColor, topRightColor, bottomRightColor);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void DrawRectangleLines(int x, int y, int width, int height, Color color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DrawRectangleLinesEx(Rectangle rectangle, float lineThickness, Color color);
	public static void DrawRectangleLines(Rectangle rectangle, float lineThickness, Color color) => DrawRectangleLinesEx(rectangle, lineThickness, color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void DrawRectangleRounded(Rectangle rectangle, float roundness, int segments, Color color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void DrawRectangleRoundedLines(Rectangle rectangle, float roundness, int segments, Color color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DrawRectangleRoundedLinesEx(Rectangle rectangle, float roundness, int segments, float lineThickness, Color color);
	public static void DrawRectangleRoundedLines(Rectangle rectangle, float roundness, int segments, float lineThickness, Color color) => DrawRectangleRoundedLinesEx(rectangle, roundness, segments, lineThickness, color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void DrawTriangle(Vector2 cornerOne, Vector2 cornerTwo, Vector2 cornerThree, Color color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void DrawTriangleLines(Vector2 cornerOne, Vector2 cornerTwo, Vector2 cornerThree, Color color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void DrawTriangleFan(Vector2[] positions, int positionCount, Color color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void DrawTriangleStrip(Vector2[] positions, int positionCount, Color color);

	// Polygons

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DrawPoly(Vector2 position, int sides, float radius, float rotation, Color color);
	public static void DrawPolygon(Vector2 position, int sides, float radius, float rotation, Color color) => DrawPoly(position, sides, radius, rotation, color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DrawPolyLines(Vector2 position, int sides, float radius, float rotation, Color color);
	public static void DrawPolygonLines(Vector2 position, int sides, float radius, float rotation, Color color) => DrawPolyLines(position, sides, radius, rotation, color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DrawPolyLinesEx(Vector2 position, int sides, float radius, float rotation, float lineThickness, Color color);
	public static void DrawPolygonLines(Vector2 position, int sides, float radius, float rotation, float lineThickness, Color color) => DrawPolyLinesEx(position, sides, radius, rotation, lineThickness, color);
}
