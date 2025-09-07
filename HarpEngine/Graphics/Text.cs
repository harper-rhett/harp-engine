namespace HarpEngine.Graphics;

public static class Text
{
	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DrawText(string text, int x, int y, int fontSize, Color color);
	public static void Draw(string text, int x, int y, int fontSize, Color color) => DrawText(text, x, y, fontSize, color);
	public static void Draw(string text, Vector2 position, int fontSize, Color color) => DrawText(text, (int)float.Round(position.X), (int)float.Round(position.Y), fontSize, color);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DrawTextEx(Font font, string text, Vector2 position, float fontSize, float spacing, Color tint);
	public static void Draw(Font font, string text, Vector2 position, float fontSize, float spacing, Color tint) => DrawTextEx(font, text, position, fontSize, spacing, tint);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DrawTextPro(Font font, string text, Vector2 position, Vector2 origin, float rotation, float fontSize, float spacing, Color tint);
	public static void Draw(Font font, string text, Vector2 position, Vector2 origin, float rotation, float fontSize, float spacing, Color tint) => DrawTextPro(font, text, position, origin, rotation, fontSize, spacing, tint);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void SetTextLineSpacing(int spacing);
	public static void SetLineSpacing(int spacing) => SetTextLineSpacing(spacing);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern int MeasureText(string text, int fontSize);
	public static int MeasureWidth(string text, int fontSize) => MeasureText(text, fontSize);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern Vector2 MeasureTextEx(Font font, string text, float fontSize, float spacing);
	public static Vector2 MeasureSize(Font font, string text, float fontSize, float spacing) => MeasureTextEx(font, text, fontSize, spacing);
}
