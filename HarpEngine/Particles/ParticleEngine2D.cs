using HarpEngine.Utilities;

namespace HarpEngine.Particles;

public sealed class ParticleEngine2D : Entity
{
	// General
	private Particle2D[] particles;
	public IReadOnlyList<Particle2D> Particles;
	private int count;
	private const int defaultInitialCount = 100;
	private ParticleRenderer2D particleRenderer = new ParticleRenderer2D.Circle(4);
	private List<Particle2DInitializer> initializers = new();
	private List<Particle2DModifier> modifiers = new();
	private FireTimer fireTimer;
	private Particle2D streamParticleTemplate;

	// Lifespan
	public bool IsExhausted => count == 0;

	public ParticleEngine2D(Scene scene, int initialCount = defaultInitialCount) : base(scene)
	{
		particles = new Particle2D[initialCount];
		Particles = particles.AsReadOnly();
		fireTimer = new();
		fireTimer.Fired += () => SpawnParticle(streamParticleTemplate);
	}

	public override void Update(float frameTime)
	{
		for (int particleIndex = count - 1; particleIndex >= 0; particleIndex--)
		{
			// Get reference
			ref Particle2D particle = ref particles[particleIndex];

			// Check if particle has died
			if (scene.Time > particle.spawnTime + particle.Lifespan)
			{
				RemoveParticle(particleIndex);
				continue;
			}

			// Apply modifiers
			foreach (Particle2DModifier modifier in modifiers) modifier(ref particle, scene.Time, frameTime);
		}
	}

	public override void Draw()
	{
		for (int particleIndex = 0; particleIndex < count; particleIndex++)
		{
			Particle2D particle = particles[particleIndex];
			particleRenderer.Draw(particle);
		}
	}

	public void RenderAsPixel()
	{
		particleRenderer = new ParticleRenderer2D.Pixel();
	}

	public void RenderAsCircle(float radius)
	{
		particleRenderer = new ParticleRenderer2D.Circle(radius);
	}

	public void RenderAsPolygon(int sides, float radius)
	{
		particleRenderer = new ParticleRenderer2D.Polygon(sides, radius);
	}

	public void RenderAsTexture(Texture texture2D)
	{
		particleRenderer = new ParticleRenderer2D.Texture(texture2D);
	}

	public void AddInitializer(Particle2DInitializer initializer)
	{
		initializers.Add(initializer);
	}

	public void AddModifier(Particle2DModifier modifier)
	{
		modifiers.Add(modifier);
	}

	private void ResizeParticles()
	{
		Particle2D[] oldParticles = particles;
		particles = new Particle2D[oldParticles.Length * 2];
		Array.Copy(oldParticles, particles, oldParticles.Length);
	}

	public void SpawnParticle(Particle2D particleTemplate)
	{
		// Initialize
		foreach (Particle2DInitializer initializer in initializers) initializer(ref particleTemplate);

		// Array business
		if (count == particles.Length) ResizeParticles();
		particleTemplate.spawnTime = scene.Time;
		particles[count++] = particleTemplate;
	}

	public void SpawnBurst(Particle2D particleTemplate, int count)
	{
		for (int particleIndex = 0; particleIndex < count; particleIndex++)
			SpawnParticle(particleTemplate);
	}

	public void SpawnStream(Particle2D particleTemplate, float frameTime, float cooldownTime)
	{
		streamParticleTemplate = particleTemplate;
		fireTimer.Update(frameTime, cooldownTime);
	}

	public void RemoveParticle(int particleIndex)
	{
		count--;
		particles[particleIndex] = particles[count];
		particles[count] = default;
	}
}
