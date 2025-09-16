# <a id="HarpEngine_Particles_ParticleModifiers"></a> Class ParticleModifiers

Namespace: [HarpEngine.Particles](HarpEngine.Particles.md)  
Assembly: HarpEngine.dll  

```csharp
public class ParticleModifiers
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[ParticleModifiers](HarpEngine.Particles.ParticleModifiers.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Methods

### <a id="HarpEngine_Particles_ParticleModifiers_AddVelocity_System_Numerics_Vector2_"></a> AddVelocity\(Vector2\)

```csharp
public static Particle2DModifier AddVelocity(Vector2 velocity)
```

#### Parameters

`velocity` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

#### Returns

 [Particle2DModifier](HarpEngine.Particles.Particle2DModifier.md)

### <a id="HarpEngine_Particles_ParticleModifiers_AdjustColor_HarpEngine_Graphics_Color_HarpEngine_Graphics_Color_HarpEngine_Animation_Curve_"></a> AdjustColor\(Color, Color, Curve\)

```csharp
public static Particle2DModifier AdjustColor(Color startColor, Color endColor, Curve curve)
```

#### Parameters

`startColor` [Color](HarpEngine.Graphics.Color.md)

`endColor` [Color](HarpEngine.Graphics.Color.md)

`curve` [Curve](HarpEngine.Animation.Curve.md)

#### Returns

 [Particle2DModifier](HarpEngine.Particles.Particle2DModifier.md)

### <a id="HarpEngine_Particles_ParticleModifiers_ApplyMovement"></a> ApplyMovement\(\)

```csharp
public static Particle2DModifier ApplyMovement()
```

#### Returns

 [Particle2DModifier](HarpEngine.Particles.Particle2DModifier.md)

### <a id="HarpEngine_Particles_ParticleModifiers_ApplyRotation"></a> ApplyRotation\(\)

```csharp
public static Particle2DModifier ApplyRotation()
```

#### Returns

 [Particle2DModifier](HarpEngine.Particles.Particle2DModifier.md)

