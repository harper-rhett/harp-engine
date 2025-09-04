﻿namespace HarpEngine.Particles;

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
	public float Lifespan;
	public Color Color;
	internal float spawnTime;

	public Particle2D()
	{
		Lifespan = Particle.DefaultLifespan;
	}
}