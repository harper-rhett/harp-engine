# <a id="HarpEngine_Particles_ParticleInitializers"></a> Class ParticleInitializers

Namespace: [HarpEngine.Particles](HarpEngine.Particles.md)  
Assembly: HarpEngine.dll  

```csharp
public static class ParticleInitializers
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ParticleInitializers](HarpEngine.Particles.ParticleInitializers.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Methods

### <a id="HarpEngine_Particles_ParticleInitializers_AddVelocity_System_Numerics_Vector2_"></a> AddVelocity\(Vector2\)

```csharp
public static Particle2DInitializer AddVelocity(Vector2 velocity)
```

#### Parameters

`velocity` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [Particle2DInitializer](HarpEngine.Particles.Particle2DInitializer.md)

### <a id="HarpEngine_Particles_ParticleInitializers_ClearVelocity"></a> ClearVelocity\(\)

```csharp
public static Particle2DInitializer ClearVelocity()
```

#### Returns

 [Particle2DInitializer](HarpEngine.Particles.Particle2DInitializer.md)

### <a id="HarpEngine_Particles_ParticleInitializers_ConicDirection_System_Numerics_Vector2_System_Single_"></a> ConicDirection\(Vector2, float\)

```csharp
public static Particle2DInitializer ConicDirection(Vector2 direction, float halfConicAngle)
```

#### Parameters

`direction` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`halfConicAngle` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Particle2DInitializer](HarpEngine.Particles.Particle2DInitializer.md)

### <a id="HarpEngine_Particles_ParticleInitializers_OverrideColor_HarpEngine_Graphics_Color_"></a> OverrideColor\(Color\)

```csharp
public static Particle2DInitializer OverrideColor(Color color)
```

#### Parameters

`color` [Color](HarpEngine.Graphics.Color.md)

#### Returns

 [Particle2DInitializer](HarpEngine.Particles.Particle2DInitializer.md)

### <a id="HarpEngine_Particles_ParticleInitializers_OverrideLifespan_System_Single_"></a> OverrideLifespan\(float\)

```csharp
public static Particle2DInitializer OverrideLifespan(float lifespan)
```

#### Parameters

`lifespan` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Particle2DInitializer](HarpEngine.Particles.Particle2DInitializer.md)

### <a id="HarpEngine_Particles_ParticleInitializers_OverridePosition_System_Numerics_Vector2_"></a> OverridePosition\(Vector2\)

```csharp
public static Particle2DInitializer OverridePosition(Vector2 position)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [Particle2DInitializer](HarpEngine.Particles.Particle2DInitializer.md)

### <a id="HarpEngine_Particles_ParticleInitializers_OverrideRotation_System_Single_"></a> OverrideRotation\(float\)

```csharp
public static Particle2DInitializer OverrideRotation(float rotation)
```

#### Parameters

`rotation` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Particle2DInitializer](HarpEngine.Particles.Particle2DInitializer.md)

### <a id="HarpEngine_Particles_ParticleInitializers_OverrideRotationSpeed_System_Single_"></a> OverrideRotationSpeed\(float\)

```csharp
public static Particle2DInitializer OverrideRotationSpeed(float rotationSpeed)
```

#### Parameters

`rotationSpeed` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Particle2DInitializer](HarpEngine.Particles.Particle2DInitializer.md)

### <a id="HarpEngine_Particles_ParticleInitializers_OverrideVelocity_System_Numerics_Vector2_"></a> OverrideVelocity\(Vector2\)

```csharp
public static Particle2DInitializer OverrideVelocity(Vector2 velocity)
```

#### Parameters

`velocity` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [Particle2DInitializer](HarpEngine.Particles.Particle2DInitializer.md)

### <a id="HarpEngine_Particles_ParticleInitializers_RandomizeDirection"></a> RandomizeDirection\(\)

```csharp
public static Particle2DInitializer RandomizeDirection()
```

#### Returns

 [Particle2DInitializer](HarpEngine.Particles.Particle2DInitializer.md)

### <a id="HarpEngine_Particles_ParticleInitializers_RandomizeLifespan_System_Single_System_Single_"></a> RandomizeLifespan\(float, float\)

```csharp
public static Particle2DInitializer RandomizeLifespan(float minimumLifespan, float maximumLifespan)
```

#### Parameters

`minimumLifespan` [float](https://learn.microsoft.com/dotnet/api/system.single)

`maximumLifespan` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Particle2DInitializer](HarpEngine.Particles.Particle2DInitializer.md)

### <a id="HarpEngine_Particles_ParticleInitializers_RandomizeRotation"></a> RandomizeRotation\(\)

```csharp
public static Particle2DInitializer RandomizeRotation()
```

#### Returns

 [Particle2DInitializer](HarpEngine.Particles.Particle2DInitializer.md)

### <a id="HarpEngine_Particles_ParticleInitializers_RandomizeRotationSpeed_System_Single_System_Single_"></a> RandomizeRotationSpeed\(float, float\)

```csharp
public static Particle2DInitializer RandomizeRotationSpeed(float minimumRotation, float maximumRotation)
```

#### Parameters

`minimumRotation` [float](https://learn.microsoft.com/dotnet/api/system.single)

`maximumRotation` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Particle2DInitializer](HarpEngine.Particles.Particle2DInitializer.md)

### <a id="HarpEngine_Particles_ParticleInitializers_RandomizeSpeed_System_Single_System_Single_"></a> RandomizeSpeed\(float, float\)

```csharp
public static Particle2DInitializer RandomizeSpeed(float minimumSpeed, float maximumSpeed)
```

#### Parameters

`minimumSpeed` [float](https://learn.microsoft.com/dotnet/api/system.single)

`maximumSpeed` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Particle2DInitializer](HarpEngine.Particles.Particle2DInitializer.md)

### <a id="HarpEngine_Particles_ParticleInitializers_Scatter_System_Single_"></a> Scatter\(float\)

```csharp
public static Particle2DInitializer Scatter(float maxRadius)
```

#### Parameters

`maxRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Particle2DInitializer](HarpEngine.Particles.Particle2DInitializer.md)

### <a id="HarpEngine_Particles_ParticleInitializers_ScatterByDirection_System_Single_"></a> ScatterByDirection\(float\)

```csharp
public static Particle2DInitializer ScatterByDirection(float maxRadius)
```

#### Parameters

`maxRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Particle2DInitializer](HarpEngine.Particles.Particle2DInitializer.md)

### <a id="HarpEngine_Particles_ParticleInitializers_SetSpeed_System_Single_"></a> SetSpeed\(float\)

```csharp
public static Particle2DInitializer SetSpeed(float speed)
```

#### Parameters

`speed` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Particle2DInitializer](HarpEngine.Particles.Particle2DInitializer.md)

