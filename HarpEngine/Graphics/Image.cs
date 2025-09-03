namespace HarpEngine.Graphics;

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct Image
{
	public void* Data;
	public int Width;
	public int Height;
	public int Mipmaps;
	public PixelFormat Format;
}
