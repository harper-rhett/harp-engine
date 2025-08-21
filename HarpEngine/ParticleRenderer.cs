namespace HarpEngine;

internal abstract class ParticleRenderer
{
	public abstract void Draw(Particle particle);

	public class Pixel : ParticleRenderer
	{
		public override void Draw(Particle particle)
		{
			DrawPixelV(particle.Position, particle.Color);
		}
	}

	public class Circle : ParticleRenderer
	{
		private float radius;

		public Circle(float radius)
		{
			this.radius = radius;
		}

		public override void Draw(Particle particle)
		{
			DrawCircleV(particle.Position, radius, particle.Color);
		}
	}

	public class Polygon : ParticleRenderer
	{
		private int sides;
		private float radius;

		public Polygon(int sides, float radius)
		{
			this.sides = sides;
			this.radius = radius;
		}

		public override void Draw(Particle particle)
		{
			DrawPoly(particle.Position, sides, radius, particle.Rotation, particle.Color);
		}
	}

	public class Texture : ParticleRenderer
	{
		private Texture2D texture2D;
		private Rectangle particleRectangle;
		private Vector2 textureOrigin;

		public Texture(Texture2D texture2D)
		{
			this.texture2D = texture2D;
			particleRectangle = new(0, 0, texture2D.Width, texture2D.Height);
			textureOrigin = new(texture2D.Width / 2f, texture2D.Height / 2f);
		}

		public override void Draw(Particle particle)
		{
			Rectangle drawRectangle = new(particle.Position, texture2D.Width, texture2D.Height);
			DrawTexturePro(texture2D, particleRectangle, drawRectangle, textureOrigin, particle.Rotation, particle.Color);
		}
	}
}
