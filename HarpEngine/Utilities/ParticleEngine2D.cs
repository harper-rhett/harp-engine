namespace HarpEngine.Utilities;

public class ParticleEngine2D : Entity
{
	// General
	private Particle2D[] particles;
	public IReadOnlyCollection<Particle2D> Particles;
	private int count;
	private const int defaultInitialCount = 100;
	private ParticleRenderer2D particleRenderer = new ParticleRenderer2D.Circle(4);
	Random random = new();

	// Movement
	public float BaseSpeed = 0;
	public float RandomSpeed = 0;
	public float SpawnRadius = 0;
	public Vector2 Gravity = Vector2.Zero;

	// Rotation
	public float StartRotation = 0;
	public bool GenerateRandomRotations;
	public float RotationSpeed = 0;

	// Extras
	public Color Color = White;

	// Lifespan
	public float ParticleLifespan = Particle.DefaultLifespan;
	public bool IsExhausted => count == 0;

	public ParticleEngine2D(Scene scene) : this(scene, defaultInitialCount) { }

	public ParticleEngine2D(Scene scene, int initialCount) : base(scene)
	{
		particles = new Particle2D[initialCount];
		Particles = particles.AsReadOnly();
	}

	public override void Update(float frameTime)
	{
		for (int particleIndex = count - 1; particleIndex >= 0; particleIndex--)
		{
			// Get reference
			ref Particle2D particle = ref particles[particleIndex];

			// Check if particle has died
			if (scene.Time > particle.SpawnTime + particle.Lifespan)
			{
				RemoveParticle(particleIndex);
				continue;
			}

			// Update particle
			particle.Velocity += Gravity * frameTime;
			particle.Position += particle.Velocity * frameTime;
			particle.Rotation += particle.RotationSpeed * frameTime;
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

	public void RenderAsTexture(Texture2D texture2D)
	{
		particleRenderer = new ParticleRenderer2D.Texture(texture2D);
	}

	private void ResizeParticles()
	{
		Particle2D[] oldParticles = particles;
		particles = new Particle2D[oldParticles.Length * 2];
		Array.Copy(oldParticles, particles, oldParticles.Length);
	}

	public void AddParticle(Particle2D particle)
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

	private Vector2 GetSpawnPosition(Vector2 position, Vector2 direction)
	{
		float randomDistance = random.NextFloat() * SpawnRadius;
		Vector2 spawnPosition = position + direction * randomDistance;
		return spawnPosition;
	}

	public void SpawnParticle(Vector2 position, Vector2? velocity = null)
	{
		// Create particle
		Particle2D particle = new(scene.Time);
		Vector2 direction = random.NextVector2();
		Vector2 spawnPosition = GetSpawnPosition(position, direction);
		particle.Position = spawnPosition;
		particle.Color = Color;
		particle.Lifespan = ParticleLifespan;

		// Velocity
		float additionalSpeed = random.NextFloat() * RandomSpeed;
		if (velocity is null) particle.Velocity = direction * (BaseSpeed + additionalSpeed);
		else particle.Velocity = velocity.Value;

		// Rotation
		particle.Rotation = StartRotation;
		if (GenerateRandomRotations) particle.Rotation += random.NextDegrees();
		if (RotationSpeed != 0)
		{
			int rotationDirection = random.NextBool() ? 1 : -1;
			particle.RotationSpeed = RotationSpeed * rotationDirection;
		}

		// Finalize
		AddParticle(particle);
	}

	public void SpawnBurst(Vector2 position, int particleCount)
	{
		for (int particleIndex = 0; particleIndex < particleCount; particleIndex++)
			SpawnParticle(position);
	}
}
