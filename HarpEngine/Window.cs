using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarpEngine;

internal abstract class Window
{
	public abstract void DrawWindow(RenderTexture2D gameRenderTexture);

	public class Bordered : Window
	{
		private Color borderColor;

		public Bordered(Color borderColor)
		{
			this.borderColor = borderColor;
		}

		public override void DrawWindow(RenderTexture2D gameRenderTexture)
		{
			int windowWidth = GetScreenWidth();
			int windowHeight = GetScreenHeight();
			int gameWidth = gameRenderTexture.Texture.Width;
			int gameHeight = gameRenderTexture.Texture.Height;

			// Does not need to be recreated every frame.
			// Can be stored as field and calculation called when game width or height is updated.
			Rectangle gameRectangle = new(0, 0, gameWidth, -gameHeight);

			// Does not need to be calculated every frame.
			// Can check if window size has changed since last frame.
			Rectangle viewportRectangle = new();
			int minimumDimension = Math.Min(windowWidth, windowHeight);
			viewportRectangle.X = (windowWidth - minimumDimension) / 2f;
			viewportRectangle.Y = (windowHeight - minimumDimension) / 2f;
			viewportRectangle.Width = minimumDimension;
			viewportRectangle.Height = minimumDimension;

			ClearBackground(borderColor);
			DrawTexturePro(gameRenderTexture.Texture, gameRectangle, viewportRectangle, Vector2.Zero, 0, White);
		}
	}

	public class Clipped : Window
	{
		public override void DrawWindow(RenderTexture2D gameRenderTexture)
		{
			int windowWidth = GetScreenWidth();
			int windowHeight = GetScreenHeight();
			float windowAspect = (float)windowWidth / windowHeight;

			int gameWidth = gameRenderTexture.Texture.Width;
			int gameHeight = gameRenderTexture.Texture.Height;

			Rectangle gameRectangle;
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

			Rectangle viewportRectangle = new(0, 0, windowWidth, windowHeight);

			DrawTexturePro(gameRenderTexture.Texture, gameRectangle, viewportRectangle, Vector2.Zero, 0, White);
		}
	}
}