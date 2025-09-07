namespace HarpEngine.Particles;

public delegate void Particle2DInitializer(ref Particle2D particle);

public static partial class ParticleInitializers
{
	private static Random random = new();

	public static Particle2DInitializer OverridePosition(Vector2 position)
	{
		return (ref Particle2D particle) => particle.Position = position;
	}

	public static Particle2DInitializer OverrideVelocity(Vector2 velocity)
	{
		return (ref Particle2D particle) => particle.Velocity = velocity;
	}

	public static Particle2DInitializer OverrideRotation(float rotation)
	{
		return (ref Particle2D particle) => particle.Rotation = rotation;
	}

	public static Particle2DInitializer OverrideRotationSpeed(float rotationSpeed)
	{
		return (ref Particle2D particle) => particle.RotationSpeed = rotationSpeed;
	}

	public static Particle2DInitializer OverrideColor(Color color)
	{
		return (ref Particle2D particle) => particle.Color = color;
	}

	public static Particle2DInitializer OverrideLifespan(float lifespan)
	{
		return (ref Particle2D particle) => particle.Lifespan = lifespan;
	}

	public static Particle2DInitializer AddVelocity(Vector2 velocity)
	{
		return (ref Particle2D particle) => particle.Velocity += velocity;
	}

	public static Particle2DInitializer SetSpeed(float speed)
	{
		return (ref Particle2D particle) =>
		{
			Vector2 direction = Vector2.Normalize(particle.Velocity);
			particle.Velocity = direction * speed;
		};
	}

	public static Particle2DInitializer RandomizeSpeed(float minimumSpeed, float maximumSpeed)
	{
		return (ref Particle2D particle) =>
		{
			float speed = random.NextFloat(minimumSpeed, maximumSpeed);
			Vector2 direction = Vector2.Normalize(particle.Velocity);
			particle.Velocity = direction * speed;
		};
	}

	public static Particle2DInitializer RandomizeDirection()
	{
		return (ref Particle2D particle) =>
		{
			Vector2 direction = random.NextVector2();
			particle.Velocity = direction;
		};
	}

	public static Particle2DInitializer ClearVelocity()
	{
		return (ref Particle2D particle) => particle.Velocity = Vector2.Zero;
	}

	public static Particle2DInitializer ScatterByDirection(float maxRadius)
	{
		return (ref Particle2D particle) =>
		{
			Vector2 direction = Vector2.Normalize(particle.Velocity);
			float distance = random.NextFloat() * maxRadius;
			particle.Position += direction * distance;
		};
	}

	public static Particle2DInitializer Scatter(float maxRadius)
	{
		return (ref Particle2D particle) =>
		{
			Vector2 direction = random.NextVector2();
			float distance = random.NextFloat() * maxRadius;
			particle.Position += direction * distance;
		};
	}

	public static Particle2DInitializer ConicDirection(Vector2 direction, float halfConicAngle)
	{
		return (ref Particle2D particle) =>
		{
			float angle = random.NextFloat(-halfConicAngle, halfConicAngle);
			Matrix3x2 rotationMatrix = Matrix3x2.CreateRotation(float.DegreesToRadians(angle));
			particle.Velocity = Vector2.Transform(direction, rotationMatrix);
		};
	}

	public static Particle2DInitializer RandomizeRotation()
	{
		return (ref Particle2D particle) => particle.Rotation = random.NextDegrees();
	}

	public static Particle2DInitializer RandomizeRotationSpeed(float minimumRotation, float maximumRotation)
	{
		return (ref Particle2D particle) =>
		{
			particle.RotationSpeed = random.NextFloat(minimumRotation, maximumRotation);
		};
	}

	public static Particle2DInitializer RandomizeLifespan(float minimumLifespan, float maximumLifespan)
	{
		return (ref Particle2D particle) =>
		{
			particle.Lifespan = random.NextFloat(minimumLifespan, maximumLifespan);
		};
	}
}
