namespace HarpEngine.Particles;

internal abstract class ParticleRenderer2D
{
	public abstract void Draw(Particle2D particle);

	private Color GetParticleColor(Particle2D particle)
	{
		float progress = 1 - (particle.timeToDeath / particle.Lifespan);
		return particle.Gradient.Sample(progress);
	}

	public class Pixel : ParticleRenderer2D
	{
		public override void Draw(Particle2D particle)
		{
			Color color = GetParticleColor(particle);
			Primitives.DrawPixel(particle.Position, color);
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
			Color color = GetParticleColor(particle);
			Primitives.DrawCircle(particle.Position, radius, color);
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
			Color color = GetParticleColor(particle);
			Primitives.DrawPolygon(particle.Position, sides, radius, particle.Rotation, color);
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
			Color color = GetParticleColor(particle);
			texture2D.Draw(particleRectangle, drawRectangle, textureOrigin, particle.Rotation, color);
		}
	}
}
