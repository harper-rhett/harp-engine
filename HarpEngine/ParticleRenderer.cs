namespace HarpEngine;

internal abstract class ParticleRenderer
{
	public abstract void Draw(Particle particle);

	public class Pixel : ParticleRenderer
	{
		public Pixel()
		{

		}

		public override void Draw(Particle particle)
		{

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

		}
	}

	public class Texture : ParticleRenderer
	{
		private Texture2D texture2D;

		public Texture(Texture2D texture2D)
		{
			this.texture2D = texture2D;
		}

		public override void Draw(Particle particle)
		{

		}
	}
}
