namespace HarpEngine.Windowing;

internal class UnclippedRenderer : WindowRenderer
{
	private Color borderColor;
	private Rectangle viewportRectangle;

	public UnclippedRenderer(Color borderColor)
	{
		this.borderColor = borderColor;
	}

	internal override void Draw(RenderTexture gameRenderTexture)
	{
		// Initialize
		RefreshValues(gameRenderTexture);
		Rectangle gameRectangle = new(0, 0, gameWidth, -gameHeight);

		// Only calculate viewport rectangle if window has been resized
		if (DidResize) CalculateViewportRectangle(windowWidth, windowHeight);

		// Clear background to draw border before drawing game
		Drawing.Clear(borderColor);
		gameRenderTexture.Texture.Draw(gameRectangle, viewportRectangle, Vector2.Zero, 0, Color.White);
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
}