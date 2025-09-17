# Particles
> `using HarpEngine.Particles`

The particle system is made to be completely modular and incredibly customizable. A system is configured in 3 separate steps:
- Initializers: Define the initial state of the particles.
- Modifiers: Define the update loop of the particles.
- Finalizers: Define what happens when particles die.

Particles also have many rendering options:
- Pixel
- Circle
- Polygon
- Texture

But a particle itself only has a few fields:
- Position
- Rotation
- Rotation speed
- Lifespan
- Color (soon to be replaced with `ColorGradient`)

And a particle can be spawned in several ways:
- One at a time
- In a burst
- In a stream

HarpEngine comes with several pre-built particle customizations for convenience, which can be found in `ParticleInitializers`, `ParticleModifiers`, and `ParticleFinalizers`. Here is an example:

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

This example is ripped directly from one of the examples hosted on GitHub. It is firework shell, and is simply shot upwards at an angle to explode into more particles. Let's break it down step-by-step:
- `ConicDirection` Initializer: Perhaps in need of a name revision, this sets the direction of particles to a upwards cone with an arc of 30 degrees.
- `SetSpeed` Initializer: Having the direction set in the previous step, this initializer launches the particles in their existing direction.
- `OverrideLifespan` Initializer: Particle properties like lifespan can be set when the particle is created, but sometimes it is more readable to do so with initializers.
- `AddVelocity` Modifier: Adds gravity to the particles.
- `ApplyMovement` Modifier: Tells the particle to move according to its position and velocity. Otherwise, particles will be static.
- `AdjustColor` Modifier: To be updated when `ColorGradient` is introduced, this modifier changes the particles color from one to another over its lifetime.
- `CreateBurst` Finalizer: Creates a burst of particles from another particle engine at death.

If you find the built in customizations are not enough, they are all based on delegates and you can design your own.