namespace HarpEngine.Graphics;

[StructLayout(LayoutKind.Sequential)]
public unsafe struct Texture : IDisposable
{
	public uint Id;
	public int Width;
	public int Height;
	public int Mipmaps;
	public PixelFormat Format;

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern Texture LoadTexture(string filePath);
	public static Texture Load(string filePath) => LoadTexture(filePath);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern Texture LoadTextureFromImage(Image image);
	public static Texture LoadFromImage(Image image) => LoadTextureFromImage(image);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern bool IsTextureValid(Texture texture);
	public bool IsValid => IsTextureValid(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void UnloadTexture(Texture texture);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void SetTextureFilter(Texture texture, TextureFilter textureFilter);
	public void SetFilter(TextureFilter textureFilter) => SetTextureFilter(this, textureFilter);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DrawTexture(Texture texture, int x, int y, Color tint);
	public void Draw(int x, int y, Color tint) => DrawTexture(this, x, y, tint);
	public void Draw(Vector2 position, Color tint) => DrawTexture(this, (int)float.Round(position.X), (int)float.Round(position.Y), tint);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DrawTextureRec(Texture texture, Rectangle source, Vector2 position, Color tint);
	public void Draw(Rectangle source, Vector2 position, Color tint) => DrawTextureRec(this, source, position, tint);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DrawTexturePro(Texture texture, Rectangle source, Rectangle destination, Vector2 origin, float rotation, Color tint);
	public void Draw(Rectangle source, Rectangle destination, Vector2 origin, float rotation, Color tint) => DrawTexturePro(this, source, destination, origin, rotation, tint);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void DrawTextureNPatch(Texture texture, NinePatch ninePatch, Rectangle destination, Vector2 origin, float rotation, Color tint);
	public static void DrawNinePatch(Texture texture, NinePatch ninePatch, Rectangle destination, Vector2 origin, float rotation, Color tint) => DrawTextureNPatch(texture, ninePatch, destination, origin, rotation, tint);

	public void Dispose()
	{
		UnloadTexture(this);
	}
}