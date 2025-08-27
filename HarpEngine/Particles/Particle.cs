using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarpEngine.Particles;

public static class Particle
{
	public const float DefaultLifespan = 10;
}

public struct Particle2D
{
	// General
	public Vector2 Position;
	public Vector2 Velocity;
	public float Rotation;
	public float RotationSpeed;
	public float SpawnTime;
	public float Lifespan = Particle.DefaultLifespan;
	public Color Color = White;

	public Particle2D(float time)
	{
		SpawnTime = time;
	}
}

public struct Particle3D
{
	// General
	public Vector3 Position;
	public Vector3 Velocity;
	public Quaternion Rotation;
	public float SpawnTime;
	public float LifeSpan = Particle.DefaultLifespan;
	public Color Color = White;

	public Particle3D(float time)
	{
		SpawnTime = time;
	}
}