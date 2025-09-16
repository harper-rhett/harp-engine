# <a id="HarpEngine_Particles_ParticleEngine2D"></a> Class ParticleEngine2D

Namespace: [HarpEngine.Particles](HarpEngine.Particles.md)  
Assembly: HarpEngine.dll  

```csharp
public sealed class ParticleEngine2D : Entity
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](HarpEngine.Entity.md) ← 
[ParticleEngine2D](HarpEngine.Particles.ParticleEngine2D.md)

#### Inherited Members

[Entity.IsUpdating](HarpEngine.Entity.md\#HarpEngine\_Entity\_IsUpdating), 
[Entity.IsRendering](HarpEngine.Entity.md\#HarpEngine\_Entity\_IsRendering), 
[Entity.UpdateLayer](HarpEngine.Entity.md\#HarpEngine\_Entity\_UpdateLayer), 
[Entity.DrawLayer](HarpEngine.Entity.md\#HarpEngine\_Entity\_DrawLayer), 
[Entity.Update\(float\)](HarpEngine.Entity.md\#HarpEngine\_Entity\_Update\_System\_Single\_), 
[Entity.Draw\(\)](HarpEngine.Entity.md\#HarpEngine\_Entity\_Draw), 
[Entity.DrawGUI\(\)](HarpEngine.Entity.md\#HarpEngine\_Entity\_DrawGUI), 
[Entity.Remove\(\)](HarpEngine.Entity.md\#HarpEngine\_Entity\_Remove), 
[Entity.OnRemove\(\)](HarpEngine.Entity.md\#HarpEngine\_Entity\_OnRemove), 
[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="HarpEngine_Particles_ParticleEngine2D__ctor_HarpEngine_Scene_System_Int32_System_Single_"></a> ParticleEngine2D\(Scene, int, float\)

```csharp
public ParticleEngine2D(Scene scene, int initialCount = 100, float streamCooldownTime = 0.1)
```

#### Parameters

`scene` [Scene](HarpEngine.Scene.md)

`initialCount` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`streamCooldownTime` [float](https://learn.microsoft.com/dotnet/api/system.single)

## Fields

### <a id="HarpEngine_Particles_ParticleEngine2D_Particles"></a> Particles

```csharp
public IReadOnlyList<Particle2D> Particles
```

#### Field Value

 [IReadOnlyList](https://learn.microsoft.com/dotnet/api/system.collections.generic.ireadonlylist\-1)<[Particle2D](HarpEngine.Particles.Particle2D.md)\>

## Properties

### <a id="HarpEngine_Particles_ParticleEngine2D_IsExhausted"></a> IsExhausted

```csharp
public bool IsExhausted { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="HarpEngine_Particles_ParticleEngine2D_IsStreaming"></a> IsStreaming

```csharp
public bool IsStreaming { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="HarpEngine_Particles_ParticleEngine2D_StreamCooldownTime"></a> StreamCooldownTime

```csharp
public float StreamCooldownTime { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="HarpEngine_Particles_ParticleEngine2D_AddFinalizer_HarpEngine_Particles_Particle2DFinalizer_"></a> AddFinalizer\(Particle2DFinalizer\)

```csharp
public void AddFinalizer(Particle2DFinalizer finalizer)
```

#### Parameters

`finalizer` [Particle2DFinalizer](HarpEngine.Particles.Particle2DFinalizer.md)

### <a id="HarpEngine_Particles_ParticleEngine2D_AddInitializer_HarpEngine_Particles_Particle2DInitializer_"></a> AddInitializer\(Particle2DInitializer\)

```csharp
public void AddInitializer(Particle2DInitializer initializer)
```

#### Parameters

`initializer` [Particle2DInitializer](HarpEngine.Particles.Particle2DInitializer.md)

### <a id="HarpEngine_Particles_ParticleEngine2D_AddModifier_HarpEngine_Particles_Particle2DModifier_"></a> AddModifier\(Particle2DModifier\)

```csharp
public void AddModifier(Particle2DModifier modifier)
```

#### Parameters

`modifier` [Particle2DModifier](HarpEngine.Particles.Particle2DModifier.md)

### <a id="HarpEngine_Particles_ParticleEngine2D_Draw"></a> Draw\(\)

```csharp
public override void Draw()
```

### <a id="HarpEngine_Particles_ParticleEngine2D_OnRemove"></a> OnRemove\(\)

```csharp
public override void OnRemove()
```

### <a id="HarpEngine_Particles_ParticleEngine2D_RemoveParticle_System_Int32_"></a> RemoveParticle\(int\)

```csharp
public void RemoveParticle(int particleIndex)
```

#### Parameters

`particleIndex` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="HarpEngine_Particles_ParticleEngine2D_RenderAsCircle_System_Single_"></a> RenderAsCircle\(float\)

```csharp
public void RenderAsCircle(float radius)
```

#### Parameters

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="HarpEngine_Particles_ParticleEngine2D_RenderAsPixel"></a> RenderAsPixel\(\)

```csharp
public void RenderAsPixel()
```

### <a id="HarpEngine_Particles_ParticleEngine2D_RenderAsPolygon_System_Int32_System_Single_"></a> RenderAsPolygon\(int, float\)

```csharp
public void RenderAsPolygon(int sides, float radius)
```

#### Parameters

`sides` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="HarpEngine_Particles_ParticleEngine2D_RenderAsTexture_HarpEngine_Graphics_Texture_"></a> RenderAsTexture\(Texture\)

```csharp
public void RenderAsTexture(Texture texture2D)
```

#### Parameters

`texture2D` [Texture](HarpEngine.Graphics.Texture.md)

### <a id="HarpEngine_Particles_ParticleEngine2D_SpawnBurst_HarpEngine_Particles_Particle2D_System_Int32_"></a> SpawnBurst\(Particle2D, int\)

```csharp
public void SpawnBurst(Particle2D particleTemplate, int count)
```

#### Parameters

`particleTemplate` [Particle2D](HarpEngine.Particles.Particle2D.md)

`count` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="HarpEngine_Particles_ParticleEngine2D_SpawnParticle_HarpEngine_Particles_Particle2D_"></a> SpawnParticle\(Particle2D\)

```csharp
public void SpawnParticle(Particle2D particleTemplate)
```

#### Parameters

`particleTemplate` [Particle2D](HarpEngine.Particles.Particle2D.md)

### <a id="HarpEngine_Particles_ParticleEngine2D_Update_System_Single_"></a> Update\(float\)

```csharp
public override void Update(float frameTime)
```

#### Parameters

`frameTime` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="HarpEngine_Particles_ParticleEngine2D_StreamFired"></a> StreamFired

```csharp
public event ParticleEngine2D.StreamFiredDelegate StreamFired
```

#### Event Type

 [ParticleEngine2D](HarpEngine.Particles.ParticleEngine2D.md).[StreamFiredDelegate](HarpEngine.Particles.ParticleEngine2D.StreamFiredDelegate.md)

