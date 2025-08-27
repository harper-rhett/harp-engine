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
public partial struct Texture2D
{
	public uint Id;
	public int Width;
	public int Height;
	public int Mipmaps;
	public PixelFormat Format;
}

[StructLayout(LayoutKind.Sequential)]
public partial struct RenderTexture2D
{
	public uint Id;
	public Texture2D Texture;
	public Texture2D Depth;

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void BeginTextureMode(RenderTexture2D renderTexture2D);
	public static void BeginDrawing(RenderTexture2D renderTexture2D) => BeginTextureMode(renderTexture2D);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void EndTextureMode();
	public static void EndDrawing() => EndTextureMode();
}

public static class Textures
{
	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern RenderTexture2D LoadRenderTexture(int width, int height);
}