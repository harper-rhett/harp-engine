namespace HarpEngine.Graphics;

public static class Text
{
	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	private static extern void DrawText(string text, int x, int y, int fontSize, Color color);
	public static void Draw(string text, int x, int y, int fontSize, Color color) => DrawText(text, x, y, fontSize, color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	private static extern int MeasureText(string text, int fontSize);
	public static int Measure(string text, int fontSize) => MeasureText(text, fontSize);
}
