namespace HarpEngine.Windowing;

internal abstract class WindowRenderer
{
	// Window fields
	protected int windowWidth;
	protected int windowHeight;
	private int previousWindowWidth;
	private int previousWindowHeight;

	// Game fields
	protected int gameWidth;
	protected int gameHeight;

	// Mouse fields
	internal abstract int MouseGameX { get; }
	internal abstract int MouseGameY { get; }

	protected bool DidResize
	{
		get
		{
			bool result = windowWidth != previousWindowWidth || windowHeight != previousWindowHeight;
			previousWindowWidth = windowWidth;
			previousWindowHeight = windowHeight;
			return result;
		}
	}

	// Fetch new values
	protected void RefreshValues(RenderTexture gameRenderTexture)
	{
		windowWidth = Window.Width;
		windowHeight = Window.Height;
		gameWidth = gameRenderTexture.Texture.Width;
		gameHeight = gameRenderTexture.Texture.Height;
	}

	// Custom implementation for game sizing
	internal abstract void Update(RenderTexture gameRenderTexture);
	internal abstract void Draw(RenderTexture gameRenderTexture);
}