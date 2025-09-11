namespace HarpEngine.Graphics;

[StructLayout(LayoutKind.Sequential)]
public struct RenderTexture : IDisposable
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

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern bool IsRenderTextureValid(RenderTexture renderTexture);
	public bool IsValid => IsRenderTextureValid(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void UnloadRenderTexture(RenderTexture renderTexture);

	public void Dispose()
	{
		UnloadRenderTexture(this);
	}
}
