# Particles
> `using HarpEngine.Particles`

Particles themselves are simple, where each particle is a `struct` with the following fields:

- Position
- Rotation
- Rotation speed
- Lifespan
- Color (soon to be replaced with `ColorGradient` to allow more controlled transitions)

This is probably no surprise to you if you have used particles in other engines. What makes particles special is the system that controls them. `ParticleEngine2D` has several rendering options:

- Pixel
- Circle
- Polygon
- Texture

And particles can be spawned in several ways:

- One at a time
- In a burst
- In a stream

But what truly sets the engine apart is how the particle behavior is defined in 3 steps:

- Initializers: Define the initial state of the particles.
- Modifiers: Define the update loop of the particles.
- Finalizers: Define what happens when particles die.

HarpEngine comes with several pre-built particle customizations for convenience, which can be found in `ParticleInitializers`, `ParticleModifiers`, and `ParticleFinalizers`. Here is an example of a firework shell that launched into the air at a random angle and spawns a firework explosion on death:

```csharp
ParticleEngine2D fireworks = new(scene);
fireworks.RenderAsCircle(fireworkRadius);
fireworks.AddInitializer(ParticleInitializers.ConicDirection(Vector2.UnitY, 15));
fireworks.AddInitializer(ParticleInitializers.SetSpeed(launchForce));
fireworks.AddInitializer(ParticleInitializers.OverrideLifespan(3));
fireworks.AddModifier(ParticleModifiers.AddVelocity(Vector2.UnitY * gravity));
fireworks.AddModifier(ParticleModifiers.ApplyMovement());
fireworks.AddModifier(ParticleModifiers.AdjustColor(Colors.Red, Colors.White, Curves.Linear));
fireworks.AddFinalizer(ParticleFinalizers.CreateBurst(explosions, 50));
```

Later:

```csharp
Particle2D firework = new()
{
	Position = new(Engine.HalfGameWidth, Engine.GameHeight),
};
fireworks.SpawnParticle(firework);
```

This example is ripped directly from one of the examples hosted on GitHub. Let's break it down step-by-step:

- `ConicDirection` Initializer: Perhaps in need of a name revision, this sets the direction of particles to a upwards cone with an arc of 30 degrees.
- `SetSpeed` Initializer: Having the direction set in the previous step, this initializer launches the particles in their existing direction.
- `OverrideLifespan` Initializer: Particle properties like lifespan can be set when the particle is created, but sometimes it is more readable to do so with initializers.
- `AddVelocity` Modifier: Adds gravity to the particles.
- `ApplyMovement` Modifier: Tells the particle to move according to its position and velocity. Otherwise, particles will be static.
- `AdjustColor` Modifier: To be updated when `ColorGradient` is introduced, this modifier changes the particles color from one to another over its lifetime.
- `CreateBurst` Finalizer: Creates a burst of particles from another particle engine at death.

The included customizations were not designed to be thorough, because the particle system is intended to be customized by the scripter. Customizations are based on delegates which are easy enough to design. Here's what the included velocity modifier looks like:

```csharp
public static Particle2DModifier AddVelocity(Vector2 velocity)
{
	return (ref Particle2D particle, float time, float frameTime) =>
	{
		particle.Velocity += velocity * frameTime;
	};
}
```

More included particle customizations will be added in the future.