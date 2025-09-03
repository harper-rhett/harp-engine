namespace HarpEngine.Graphics;

public enum BlendMode
{
	Alpha = 0,
	Additive,
	Multiplied,
	AddColors,
	SubtractColors,
	AlphaPremultiply,
	Custom,
	CustomSeparate
}

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

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void BeginBlendMode(BlendMode blendMode);
	public static void BeginBlending(BlendMode blendMode) => BeginBlendMode(blendMode);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void EndBlendMode();
	public static void EndBlending() => EndBlendMode();
}
