namespace HarpEngine.Windowing;

internal class BorderedRenderer : WindowRenderer
{
	private Color borderColor;
	private Rectangle viewportRectangle;

	public BorderedRenderer(Color borderColor)
	{
		this.borderColor = borderColor;
	}

	internal override void Draw(RenderTexture2D gameRenderTexture)
	{
		// Initialize
		RefreshValues(gameRenderTexture);
		Rectangle gameRectangle = new(0, 0, gameWidth, -gameHeight);

		// Only calculate viewport rectangle if window has been resized
		if (DidResize) CalculateViewportRectangle(windowWidth, windowHeight);

		// Clear background to draw border before drawing game
		Drawing.Clear(borderColor);
		Drawing.DrawTexture(gameRenderTexture.Texture, gameRectangle, viewportRectangle, Vector2.Zero, 0, Color.White);
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