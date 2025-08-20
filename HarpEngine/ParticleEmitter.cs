using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarpEngine;

public struct Particle
{
	public Vector2 Position;
	public float Rotation;
	public float RotationSpeed;
	public float Lifespan;
	public float SpawnTime;
}

public class ParticleEmitter : Entity
{
	private Particle[] particles;
	private int count;

	private const int InitialCount = 100;

	public ParticleEmitter()
	{
		particles = new Particle[InitialCount];
	}

	public override void Update(float frameTime)
	{
		for (int particleIndex = count - 1; particleIndex >= 0; particleIndex--)
		{

		}
	}

	public override void Draw()
	{

	}

	public void RenderAsPixel()
	{

	}

	public void RenderAsTexture(Texture2D texture2D)
	{

	}

	public void RenderAsCircle(float radius)
	{

	}

	public void RenderAsPolygon(int sides, float radius)
	{
		
	}

	private void ResizeParticles()
	{
		Particle[] oldParticles = particles;
		particles = new Particle[oldParticles.Length * 2];
		Array.Copy(oldParticles, particles, oldParticles.Length);
	}

	public void AddParticle(Particle particle)
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
}
