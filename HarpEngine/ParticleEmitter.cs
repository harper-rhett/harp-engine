namespace HarpEngine;

public struct Particle
{
	public Vector2 Position;
	public float Rotation;
	public float RotationSpeed;
	public float Lifespan;
	public float SpawnTime;
	public Color color;
}

public class ParticleEmitter : Entity
{
	private Particle[] particles;
	private int count;
	private int initialCount = 100;

	private ParticleRenderer particleRenderer = new ParticleRenderer.Circle(8);

	public ParticleEmitter()
	{
		particles = new Particle[initialCount];
	}

	public ParticleEmitter(int initialCount)
	{
		this.initialCount = initialCount;
		particles = new Particle[initialCount];
	}

	public override void Update(float frameTime)
	{
		for (int particleIndex = count - 1; particleIndex >= 0; particleIndex--)
		{

		}
	}

	public override void Draw()
	{
		for (int particleIndex = 0; particleIndex < count; particleIndex++)
		{
			Particle particle = particles[particleIndex];
			particleRenderer.Draw(particle);
		}
	}

	public void RenderAsPixel()
	{
		particleRenderer = new ParticleRenderer.Pixel();
	}

	public void RenderAsCircle(float radius)
	{
		particleRenderer = new ParticleRenderer.Circle(radius);
	}

	public void RenderAsPolygon(int sides, float radius)
	{
		particleRenderer = new ParticleRenderer.Polygon(sides, radius);
	}

	public void RenderAsTexture(Texture2D texture2D)
	{
		particleRenderer = new ParticleRenderer.Texture(texture2D);
	}

	private void ResizeParticles()
	{
		Particle[] oldParticles = particles;
		particles = new Particle[oldParticles.Length * 2];
		Array.Copy(oldParticles, particles, oldParticles.Length);
	}

	public void AddParticle(Particle particle)
	{
		if (count == particles.Length) ResizeParticles();
		particles[count++] = particle;
	}

	public void RemoveParticle(int particleIndex)
	{
		count--;
		particles[particleIndex] = particles[count];
		particles[count] = default;
	}
}
