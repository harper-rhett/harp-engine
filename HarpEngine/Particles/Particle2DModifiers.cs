namespace HarpEngine.Particles;

public delegate void Particle2DModifier(ref Particle2D particle, float frameTime);

public partial class ParticleModifiers
{
	public static Particle2DModifier ApplyMovement()
	{
		Particle2DModifier particleInitializer = (ref Particle2D particle, float frameTime) =>
		{
			particle.Position += particle.Velocity * frameTime;
		};

		return particleInitializer;
	}

	public static Particle2DModifier ApplyRotation()
	{
		Particle2DModifier particleInitializer = (ref Particle2D particle, float frameTime) =>
		{
			particle.Rotation += particle.RotationSpeed * frameTime;
		};

		return particleInitializer;
	}

	public static Particle2DModifier AddVelocity(Vector2 velocity)
	{
		Particle2DModifier particleInitializer = (ref Particle2D particle, float frameTime) =>
		{
			particle.Velocity += velocity * frameTime;
		};

		return particleInitializer;
	}
}
