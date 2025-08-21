using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarpEngine.Utilities;

public struct Particle
{
	// General
	public Vector2 Position;
	public Vector2 Velocity;
	public float Rotation;
	public float RotationSpeed;
	public float SpawnTime;
	public float Lifespan = DefaultLifespan;
	public Color Color = White;

	// Settings
	public const float DefaultLifespan = 10;

	public Particle(float time)
	{
		SpawnTime = time;
	}
}
