using HarpEngine.Utilities;

namespace HarpEngine.Particles;

public sealed class ParticleEngine2D : Entity
{
	// General
	private Particle2D[] particles;
	private int count;
	private ParticleRenderer2D particleRenderer = new ParticleRenderer2D.Circle(4);
	private List<Particle2DInitializer> initializers = new();
	private List<Particle2DModifier> modifiers = new();
	private List<Particle2DFinalizer> finalizers = new();
	private FireTimer fireTimer;

	// Defaults
	private const int defaultInitialCount = 100;
	private const float defaultStreamCooldownTime = 0.1f;

	// Interface
	public IReadOnlyList<Particle2D> Particles;
	public bool IsExhausted => count == 0;
	public float StreamCooldownTime
	{
		get => fireTimer.CooldownTime;
		set => fireTimer.CooldownTime = value;
	}
	public bool IsStreaming
	{
		get => fireTimer.IsUpdating;
		set => fireTimer.IsUpdating = value;
	}
	public delegate void StreamFiredDelegate(out Particle2D particleTemplate);
	public event StreamFiredDelegate StreamFired;

	public ParticleEngine2D(Scene scene, int initialCount = defaultInitialCount, float streamCooldownTime = defaultStreamCooldownTime) : base(scene)
	{
		particles = new Particle2D[initialCount];
		Particles = particles.AsReadOnly();
		fireTimer = new(scene, streamCooldownTime);
		fireTimer.Fired += SpawnStream;
		fireTimer.Start();
		fireTimer.IsUpdating = false;
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
				foreach (Particle2DFinalizer finalizer in finalizers) finalizer(particle, this);
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

	public void AddInitializer(Particle2DInitializer initializer) => initializers.Add(initializer);
	public void AddModifier(Particle2DModifier modifier) => modifiers.Add(modifier);
	public void AddFinalizer(Particle2DFinalizer finalizer) => finalizers.Add(finalizer);

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

	private void SpawnStream()
	{
		if (StreamFired is null) return;

		foreach (StreamFiredDelegate streamFired in StreamFired.GetInvocationList())
		{
			streamFired(out Particle2D particleTemplate);
			SpawnParticle(particleTemplate);
		}
	}

	public void RemoveParticle(int particleIndex)
	{
		count--;
		particles[particleIndex] = particles[count];
		particles[count] = default;
	}

	public override void OnRemove()
	{
		fireTimer.Remove();
	}
}
