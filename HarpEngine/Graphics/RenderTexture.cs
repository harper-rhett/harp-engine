namespace HarpEngine.Graphics;

[StructLayout(LayoutKind.Sequential)]
public struct RenderTexture
{
	public uint Id;
	public Texture Texture;
	public Texture Depth;

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void BeginTextureMode(RenderTexture renderTexture2D);
	public static void BeginDrawing(RenderTexture renderTexture2D) => BeginTextureMode(renderTexture2D);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void EndTextureMode();
	public static void EndDrawing() => EndTextureMode();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern RenderTexture LoadRenderTexture(int width, int height);
	public static RenderTexture Load(int width, int height) => LoadRenderTexture(width, height);
}
