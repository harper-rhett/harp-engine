namespace HarpEngine.Particles;

public delegate void Particle2DModifier(ref Particle2D particle, float time, float frameTime);

public partial class ParticleModifiers
{
	public static Particle2DModifier ApplyMovement()
	{
		return (ref Particle2D particle, float time, float frameTime) =>
		{
			particle.Position += particle.Velocity * frameTime;
		};
	}

	public static Particle2DModifier ApplyRotation()
	{
		return (ref Particle2D particle, float time, float frameTime) =>
		{
			particle.Rotation += particle.RotationSpeed * frameTime;
		};
	}

	public static Particle2DModifier AddVelocity(Vector2 velocity)
	{
		return (ref Particle2D particle, float time, float frameTime) =>
		{
			particle.Velocity += velocity * frameTime;
		};
	}
}
