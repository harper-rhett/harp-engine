namespace HarpEngine;

internal abstract class Window
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
		windowWidth = GetScreenWidth();
		windowHeight = GetScreenHeight();
		gameWidth = gameRenderTexture.Texture.Width;
		gameHeight = gameRenderTexture.Texture.Height;
	}

	// Custom implementation for game sizing
	public abstract void Draw(RenderTexture2D gameRenderTexture);

	// No clipping
	public class Bordered : Window
	{
		private Color borderColor;
		private Rectangle viewportRectangle;

		public Bordered(Color borderColor)
		{
			this.borderColor = borderColor;
		}

		public override void Draw(RenderTexture2D gameRenderTexture)
		{
			// Initialize
			RefreshValues(gameRenderTexture);
			Rectangle gameRectangle = new(0, 0, gameWidth, -gameHeight);

			// Only calculate viewport rectangle if window has been resized
			if (DidResize) CalculateViewportRectangle(windowWidth, windowHeight);

			// Clear background to draw border before drawing game
			ClearBackground(borderColor);
			DrawTexturePro(gameRenderTexture.Texture, gameRectangle, viewportRectangle, Vector2.Zero, 0, White);
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

	// Clip the smallest dimension
	public class Clipped : Window
	{
		private Rectangle gameRectangle;

		public override void Draw(RenderTexture2D gameRenderTexture)
		{
			// Initialize
			RefreshValues(gameRenderTexture);
			Rectangle viewportRectangle = new(0, 0, windowWidth, windowHeight);

			// Only calculare game rectangle if window has been resized
			if (DidResize) CalculateGameRectangle(windowWidth, windowHeight, gameWidth, gameHeight);

			// Draw game clipped
			DrawTexturePro(gameRenderTexture.Texture, gameRectangle, viewportRectangle, Vector2.Zero, 0, White);
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
}