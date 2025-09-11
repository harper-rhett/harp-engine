namespace HarpEngine.Graphics;

[StructLayout(LayoutKind.Sequential)]
public partial struct NinePatch
{
	public Rectangle Source;
	public int Left;
	public int Top;
	public int Right;
	public int Bottom;
	public NinePatchLayout Layout;
}

public enum NinePatchLayout
{
	NinePatch = 0,
	ThreePatchVertical,
	ThreePatchHorizontal
}