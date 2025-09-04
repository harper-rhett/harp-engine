namespace HarpEngine.Particles;

public delegate void Particle2DInitializer(ref Particle2D particle);

public static partial class ParticleInitializers
{
	private static Random random = new();

	public static Particle2DInitializer AddVelocity(Vector2 velocity)
	{
		Particle2DInitializer particleInitializer = (ref Particle2D particle) =>
		{
			particle.Velocity += velocity;
		};

		return particleInitializer;
	}

	public static Particle2DInitializer SetSpeed(float speed)
	{
		Particle2DInitializer particleInitializer = (ref Particle2D particle) =>
		{
			Vector2 direction = Vector2.Normalize(particle.Velocity);
			particle.Velocity = direction * speed;
		};

		return particleInitializer;
	}

	public static Particle2DInitializer RandomizeSpeed(float minimumSpeed, float maximumSpeed)
	{
		Particle2DInitializer particleInitializer = (ref Particle2D particle) =>
		{
			float speed = random.NextFloat(minimumSpeed, maximumSpeed);
			Vector2 direction = Vector2.Normalize(particle.Velocity);
			particle.Velocity = direction * speed;
		};

		return particleInitializer;
	}

	public static Particle2DInitializer RandomizeDirection()
	{
		Particle2DInitializer particleInitializer = (ref Particle2D particle) =>
		{
			Vector2 direction = random.NextVector2();
			particle.Velocity = direction;
		};

		return particleInitializer;
	}

	public static Particle2DInitializer ClearVelocity()
	{
		Particle2DInitializer particleInitializer = (ref Particle2D particle) =>
		{
			particle.Velocity = Vector2.Zero;
		};

		return particleInitializer;
	}

	public static Particle2DInitializer ScatterByDirection(float maxRadius)
	{
		Particle2DInitializer particleInitializer = (ref Particle2D particle) =>
		{
			Vector2 direction = Vector2.Normalize(particle.Velocity);
			float distance = random.NextFloat() * maxRadius;
			particle.Position += direction * distance;
		};

		return particleInitializer;
	}

	public static Particle2DInitializer Scatter(float maxRadius)
	{
		Particle2DInitializer particleInitializer = (ref Particle2D particle) =>
		{
			Vector2 direction = random.NextVector2();
			float distance = random.NextFloat() * maxRadius;
			particle.Position += direction * distance;
		};

		return particleInitializer;
	}

	public static Particle2DInitializer RandomizeRotation()
	{
		Particle2DInitializer particleInitializer = (ref Particle2D particle) =>
		{
			particle.Rotation = random.NextDegrees();
		};

		return particleInitializer;
	}

	public static Particle2DInitializer RandomizeRotationSpeed(float minimumRotation, float maximumRotation)
	{
		Particle2DInitializer particleInitializer = (ref Particle2D particle) =>
		{
			float rotationSpeed = random.NextFloat(minimumRotation, maximumRotation);
			particle.RotationSpeed = rotationSpeed;
		};

		return particleInitializer;
	}
}
