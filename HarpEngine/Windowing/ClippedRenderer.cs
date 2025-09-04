namespace HarpEngine.Windowing;

internal class ClippedRenderer : WindowRenderer
{
	private Rectangle gameRectangle;

	internal override void Draw(RenderTexture gameRenderTexture)
	{
		// Initialize
		RefreshValues(gameRenderTexture);
		Rectangle viewportRectangle = new(0, 0, windowWidth, windowHeight);

		// Only calculate game rectangle if window has been resized
		if (DidResize) CalculateGameRectangle(windowWidth, windowHeight, gameWidth, gameHeight);

		// Draw game clipped
		gameRenderTexture.Texture.Draw(gameRectangle, viewportRectangle, Vector2.Zero, 0, Colors.White);
	}

	private void CalculateGameRectangle(int windowWidth, int windowHeight, int gameWidth, int gameHeight)
	{
		float windowAspect = (float)windowWidth / windowHeight;
		if (windowWidth > windowHeight)
		{
			float newGameHeight = gameHeight / windowAspect;
			float heightDifference = gameHeight - newGameHeight;
			float yOffset = heightDifference / 2f;
			gameRectangle = new(0, yOffset, gameWidth, -newGameHeight);
		}
		else
		{
			float newGameWidth = gameWidth * windowAspect;
			float widthDifference = gameWidth - newGameWidth;
			float xOffset = widthDifference / 2f;
			gameRectangle = new(xOffset, 0, newGameWidth, -gameHeight);
		}
	}
}
