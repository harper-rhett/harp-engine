namespace HarpEngine.Graphics;

public static class Text
{
	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	private static extern void DrawText(string text, int x, int y, int fontSize, Color color);
	public static void Draw(string text, int x, int y, int fontSize, Color color) => DrawText(text, x, y, fontSize, color);
	public static void Draw(string text, Vector2 position, int fontSize, Color color) => DrawText(text, (int)float.Round(position.X), (int)float.Round(position.Y), fontSize, color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	private static extern void DrawTextEx(Font font, string text, Vector2 position, float fontSize, float spacing, Color tint);
	public static void Draw(Font font, string text, Vector2 position, float fontSize, float spacing, Color tint) => DrawTextEx(font, text, position, fontSize, spacing, tint);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	private static extern void DrawTextPro(Font font, string text, Vector2 position, Vector2 origin, float rotation, float fontSize, float spacing, Color tint);
	public static void Draw(Font font, string text, Vector2 position, Vector2 origin, float rotation, float fontSize, float spacing, Color tint) => DrawTextPro(font, text, position, origin, rotation, fontSize, spacing, tint);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	private static extern int MeasureText(string text, int fontSize);
	public static int Measure(string text, int fontSize) => MeasureText(text, fontSize);
}
