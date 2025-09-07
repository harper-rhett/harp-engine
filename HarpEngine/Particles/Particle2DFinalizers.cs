namespace HarpEngine.Particles;

public delegate void Particle2DFinalizer(Particle2D particle, ParticleEngine2D engine);

public static class ParticleFinalizers
{
	public static Particle2DFinalizer CreateBurst(ParticleEngine2D burstEngine, int particleCount)
	{
		return (Particle2D particle, ParticleEngine2D engine) =>
		{
			Particle2D particleTemplate = new()
			{
				Position = particle.Position,
			};
			burstEngine.SpawnBurst(particleTemplate, particleCount);
		};
	}
}
