namespace HarpEngine;

public abstract class Window
{
	// Window fields
	protected int windowWidth;
	protected int windowHeight;
	private int previousWindowWidth;
	private int previousWindowHeight;

	// Game fields
	protected int gameWidth;
	protected int gameHeight;

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
	protected void RefreshValues(RenderTexture2D gameRenderTexture)
	{
		windowWidth = Raylib.GetScreenWidth();
		windowHeight = Raylib.GetScreenHeight();
		gameWidth = gameRenderTexture.Texture.Width;
		gameHeight = gameRenderTexture.Texture.Height;
	}

	// Custom implementation for game sizing
	internal abstract void Draw(RenderTexture2D gameRenderTexture);

	private static void SetState(ConfigFlags configFlags, bool isEnabled)
	{
		if (isEnabled) Raylib.SetWindowState(configFlags);
		else Raylib.ClearWindowState(configFlags);
	}

	public static void SetResizable(bool isResizable) => SetState(ConfigFlags.ResizableWindow, isResizable);
	public static void SetMaximized(bool isMaximized) => SetState(ConfigFlags.MaximizedWindow, isMaximized);
}