namespace HarpEngine.Particles;

internal abstract class ParticleRenderer2D
{
	public abstract void Draw(Particle2D particle);

	public class Pixel : ParticleRenderer2D
	{
		public override void Draw(Particle2D particle)
		{
			Primitives.DrawPixel(particle.Position, particle.Color);
		}
	}

	public class Circle : ParticleRenderer2D
	{
		private float radius;

		public Circle(float radius)
		{
			this.radius = radius;
		}

		public override void Draw(Particle2D particle)
		{
			Primitives.DrawCircle(particle.Position, radius, particle.Color);
		}
	}

	public class Polygon : ParticleRenderer2D
	{
		private int sides;
		private float radius;

		public Polygon(int sides, float radius)
		{
			this.sides = sides;
			this.radius = radius;
		}

		public override void Draw(Particle2D particle)
		{
			Primitives.DrawPolygon(particle.Position, sides, radius, particle.Rotation, particle.Color);
		}
	}

	public class Texture : ParticleRenderer2D
	{
		private Graphics.Texture texture2D;
		private Rectangle particleRectangle;
		private Vector2 textureOrigin;

		public Texture(Graphics.Texture texture2D)
		{
			this.texture2D = texture2D;
			particleRectangle = new(0, 0, texture2D.Width, texture2D.Height);
			textureOrigin = new(texture2D.Width / 2f, texture2D.Height / 2f);
		}

		public override void Draw(Particle2D particle)
		{
			Rectangle drawRectangle = new(particle.Position, texture2D.Width, texture2D.Height);
			texture2D.Draw(particleRectangle, drawRectangle, textureOrigin, particle.Rotation, particle.Color);
		}
	}
}
