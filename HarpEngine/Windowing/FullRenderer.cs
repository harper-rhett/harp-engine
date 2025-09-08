namespace HarpEngine.Windowing;

internal class FullRenderer : WindowRenderer
{
	private Color borderColor;
	private Rectangle gameRectangle;
	private Rectangle viewportRectangle;

	public FullRenderer(Color borderColor)
	{
		this.borderColor = borderColor;
	}

	private int mouseGameX;
	internal override int MouseGameX => mouseGameX;

	private int mouseGameY;
	internal override int MouseGameY => mouseGameY;

	internal override void Update(RenderTexture gameRenderTexture)
	{
		// Initialize
		RefreshValues(gameRenderTexture);
		gameRectangle = new(0, 0, gameWidth, -gameHeight);

		// Only calculate viewport rectangle if window has been resized
		if (DidResize) CalculateViewportRectangle(windowWidth, windowHeight);
		CalculateMouse();
	}

	internal override void Draw(RenderTexture gameRenderTexture)
	{
		// Clear background to draw border before drawing game
		Drawing.Clear(borderColor);
		gameRenderTexture.Texture.Draw(gameRectangle, viewportRectangle, Vector2.Zero, 0, Colors.White);
	}

	private void CalculateViewportRectangle(int windowWidth, int windowHeight)
	{
		viewportRectangle = new();
		int minimumDimension = Math.Min(windowWidth, windowHeight);
		viewportRectangle.X = (windowWidth - minimumDimension) / 2f;
		viewportRectangle.Y = (windowHeight - minimumDimension) / 2f;
		viewportRectangle.Width = minimumDimension;
		viewportRectangle.Height = minimumDimension;
	}

	private void CalculateMouse()
	{
		float widthRatio = viewportRectangle.Width / gameRectangle.Width;
		float viewportX = float.Clamp(Mouse.WindowX - viewportRectangle.X, 0, viewportRectangle.Width);
		float gameX = viewportX / widthRatio;
		mouseGameX = (int)gameX;

		float heightRatio = -viewportRectangle.Height / gameRectangle.Height;
		float viewportY = float.Clamp(Mouse.WindowY - viewportRectangle.Y, 0, viewportRectangle.Height);
		float gameY = viewportY / heightRatio;
		mouseGameY = (int)gameY;
	}
}