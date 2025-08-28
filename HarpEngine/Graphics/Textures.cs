namespace HarpEngine.Graphics;

public enum PixelFormat
{
	UncompressedGrayscale = 1,
	UncompressedGrayAlpha,
	UncompressedR5G6B5,
	UncompressedR8G8B8,
	UncompressedR5G5B5A1,
	UncompressedR4G4B4A4,
	UncompressedR8G8B8A8,
	UncompressedR32,
	UncompressedR32G32B32,
	UncompressedR32G32B32A32,
	UncompressedR16,
	UncompressedR16G16B16,
	UncompressedR16G16B16A16,
	CompressedDxt1Rgb,
	CompressedDxt1Rgba,
	CompressedDxt3Rgba,
	CompressedDxt5Rgba,
	CompressedEtc1Rgb,
	CompressedEtc2Rgb,
	CompressedEtc2EacRgba,
	CompressedPvrtRgb,
	CompressedPvrtRgba,
	CompressedAstc4X4Rgba,
	CompressedAstc8X8Rgba
}

[StructLayout(LayoutKind.Sequential)]
public unsafe struct Texture
{
	public uint Id;
	public int Width;
	public int Height;
	public int Mipmaps;
	public PixelFormat Format;

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	private static extern Texture LoadTexture(string filePath);
	public static Texture Load(string filePath) => LoadTexture(filePath);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DrawTexture(Texture texture, int x, int y, Color tint);
	public void Draw(int x, int y, Color tint) => DrawTexture(this, x, y, tint);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DrawTextureRec(Texture texture, Rectangle source, Vector2 position, Color tint);
	public void Draw(Rectangle source, Vector2 position, Color tint) => DrawTextureRec(this, source, position, tint);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DrawTexturePro(Texture texture, Rectangle source, Rectangle destination, Vector2 origin, float rotation, Color tint);
	public void Draw(Rectangle source, Rectangle destination, Vector2 origin, float rotation, Color tint) => DrawTexturePro(this, source, destination, origin, rotation, tint);
}

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

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct Image
{
	public void* Data;
	public int Width;
	public int Height;
	public int Mipmaps;
	public PixelFormat Format;
}