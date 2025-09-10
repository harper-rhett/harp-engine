namespace HarpEngine.Graphics;

public static class Spline
{
	// Drawing

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DrawSplineLinear(Vector2[] positions, int positionCount, float thickness, Color color);
	public static void DrawLinear(Vector2[] positions, int positionCount, float thickness, Color color) => DrawSplineLinear(positions, positionCount, thickness, color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DrawSplineBasis(Vector2[] positions, int positionCount, float thickness, Color color);
	public static void DrawBasis(Vector2[] positions, int positionCount, float thickness, Color color) => DrawSplineBasis(positions, positionCount, thickness, color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DrawSplineCatmullRom(Vector2[] positions, int positionCount, float thickness, Color color);
	public static void DrawCatmullRom(Vector2[] positions, int positionCount, float thickness, Color color) => DrawSplineCatmullRom(positions, positionCount, thickness, color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DrawSplineBezierQuadratic(Vector2[] positions, int positionCount, float thickness, Color color);
	public static void DrawBezierQuadratic(Vector2[] positions, int positionCount, float thickness, Color color) => DrawSplineBezierQuadratic(positions, positionCount, thickness, color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DrawSplineBezierCubic(Vector2[] positions, int positionCount, float thickness, Color color);
	public static void DrawBezierCubic(Vector2[] positions, int positionCount, float thickness, Color color) => DrawSplineBezierCubic(positions, positionCount, thickness, color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DrawSplineSegmentLinear(Vector2 startPosition, Vector2 endPosition, float thickness, Color color);
	public static void DrawSegmentLinear(Vector2 startPosition, Vector2 endPosition, float thickness, Color color) => DrawSplineSegmentLinear(startPosition, endPosition, thickness, color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DrawSplineSegmentBasis(Vector2 positionOne, Vector2 positionTwo, Vector2 positionThree, Vector2 positionFour, float thickness, Color color);
	public static void DrawSegmentBasis(Vector2 positionOne, Vector2 positionTwo, Vector2 positionThree, Vector2 positionFour, float thickness, Color color) => DrawSplineSegmentBasis(positionOne, positionTwo, positionThree, positionFour, thickness, color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DrawSplineSegmentCatmullRom(Vector2 positionOne, Vector2 positionTwo, Vector2 positionThree, Vector2 positionFour, float thickness, Color color);
	public static void DrawSegmentCatmullRom(Vector2 positionOne, Vector2 positionTwo, Vector2 positionThree, Vector2 positionFour, float thickness, Color color) => DrawSplineSegmentCatmullRom(positionOne, positionTwo, positionThree, positionFour, thickness, color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DrawSplineSegmentBezierQuadratic(Vector2 positionOne, Vector2 controlPosition, Vector2 positionTwo, float thickness, Color color);
	public static void DrawSegmentBezierQuadratic(Vector2 positionOne, Vector2 controlPosition, Vector2 positionTwo, float thickness, Color color) => DrawSplineSegmentBezierQuadratic(positionOne, controlPosition, positionTwo, thickness, color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DrawSplineSegmentBezierCubic(Vector2 positionOne, Vector2 controlPositionOne, Vector2 controlPositionTwo, Vector2 positionTwo, float thickness, Color color);
	public static void DrawSegmentBezierCubic(Vector2 positionOne, Vector2 controlPositionOne, Vector2 controlPositionTwo, Vector2 positionTwo, float thickness, Color color) => DrawSplineSegmentBezierCubic(positionOne, controlPositionOne, controlPositionTwo, positionTwo, thickness, color);

	// Math

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern Vector2 GetSplinePointLinear(Vector2 startPosition, Vector2 endPosition, float progress);
	public static Vector2 GetPointLinear(Vector2 startPosition, Vector2 endPosition, float progress) => GetSplinePointLinear(startPosition, endPosition, progress);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern Vector2 GetSplinePointBasis(Vector2 positionOne, Vector2 positionTwo, Vector2 positionThree, Vector2 positionFour, float progress);
	public static Vector2 GetPointBasis(Vector2 positionOne, Vector2 positionTwo, Vector2 positionThree, Vector2 positionFour, float progress) => GetSplinePointBasis(positionOne, positionTwo, positionThree, positionFour, progress);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern Vector2 GetSplinePointCatmullRom(Vector2 positionOne, Vector2 positionTwo, Vector2 positionThree, Vector2 positionFour, float progress);
	public static Vector2 GetPointCatmullRom(Vector2 positionOne, Vector2 positionTwo, Vector2 positionThree, Vector2 positionFour, float progress) => GetSplinePointCatmullRom(positionOne, positionTwo, positionThree, positionFour, progress);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern Vector2 GetSplinePointBezierQuad(Vector2 positionOne, Vector2 controlPosition, Vector2 positionTwo, float progress);
	public static Vector2 GetPointBezierQuad(Vector2 positionOne, Vector2 controlPosition, Vector2 positionTwo, float progress) => GetSplinePointBezierQuad(positionOne, controlPosition, positionTwo, progress);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern Vector2 GetSplinePointBezierCubic(Vector2 positionOne, Vector2 controlPositionOne, Vector2 controlPositionTwo, Vector2 positionTwo, float progress);
	public static Vector2 GetPointBezierCubic(Vector2 positionOne, Vector2 controlPositionOne, Vector2 controlPositionTwo, Vector2 positionTwo, float progress) => GetSplinePointBezierCubic(positionOne, controlPositionOne, controlPositionTwo, positionTwo, progress);
}
