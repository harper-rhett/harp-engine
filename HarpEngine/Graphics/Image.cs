namespace HarpEngine.Graphics;

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct Image : IDisposable
{
	public void* Data;
	public int Width;
	public int Height;
	public int Mipmaps;
	public PixelFormat Format;

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern Image LoadImage(string fileName);
	public static Image Load(string fileName) => LoadImage(fileName);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern Image LoadImageRaw(string fileName, int width, int height, PixelFormat pixelFormat, int headerSize);
	public static Image LoadRaw(string fileName, int width, int height, PixelFormat pixelFormat, int headerSize) => LoadImageRaw(fileName, width, height, pixelFormat, headerSize);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern Image LoadImageFromTexture(Texture texture);
	public static Image LoadFromTexture(Texture texture) => LoadImageFromTexture(texture);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern bool IsImageValid(Image image);
	public bool IsValid => IsImageValid(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void UnloadImage(Image image);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern bool ExportImage(Image image, string fileName);
	public void Export(string fileName, out bool success)
	{
		success = ExportImage(this, fileName);
	}

	public void Dispose()
	{
		UnloadImage(this);
	}
}
