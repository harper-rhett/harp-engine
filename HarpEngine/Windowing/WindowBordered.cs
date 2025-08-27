using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
		Raylib.ClearBackground(borderColor);
		Raylib.DrawTexturePro(gameRenderTexture.Texture, gameRectangle, viewportRectangle, Vector2.Zero, 0, White);
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