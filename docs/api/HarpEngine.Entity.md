# <a id="HarpEngine_Entity"></a> Class Entity

Namespace: [HarpEngine](HarpEngine.md)  
Assembly: HarpEngine.dll  

```csharp
public abstract class Entity
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](HarpEngine.Entity.md)

#### Derived

[Camera](HarpEngine.Camera.md), 
[Circle](HarpEngine.Shapes.Circle.md), 
[Easer](HarpEngine.Animation.Easer.md), 
[FireTimer](HarpEngine.Utilities.FireTimer.md), 
[MusicPlayer](HarpEngine.Audio.MusicPlayer.md), 
[MusicRepeater](HarpEngine.Audio.MusicRepeater.md), 
[MusicRepeater2Part](HarpEngine.Audio.MusicRepeater2Part.md), 
[ParticleEngine2D](HarpEngine.Particles.ParticleEngine2D.md), 
[Polygon](HarpEngine.Shapes.Polygon.md), 
[TriggerTimer](HarpEngine.Utilities.TriggerTimer.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="HarpEngine_Entity__ctor_HarpEngine_Scene_"></a> Entity\(Scene\)

```csharp
public Entity(Scene scene)
```

#### Parameters

`scene` [Scene](HarpEngine.Scene.md)

## Fields

### <a id="HarpEngine_Entity_IsRendering"></a> IsRendering

```csharp
public bool IsRendering
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="HarpEngine_Entity_IsUpdating"></a> IsUpdating

```csharp
public bool IsUpdating
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="HarpEngine_Entity_scene"></a> scene

```csharp
protected Scene scene
```

#### Field Value

 [Scene](HarpEngine.Scene.md)

## Properties

### <a id="HarpEngine_Entity_DrawLayer"></a> DrawLayer

```csharp
public int DrawLayer { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="HarpEngine_Entity_UpdateLayer"></a> UpdateLayer

```csharp
public int UpdateLayer { get; set; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="HarpEngine_Entity_Draw"></a> Draw\(\)

```csharp
public virtual void Draw()
```

### <a id="HarpEngine_Entity_DrawGUI"></a> DrawGUI\(\)

```csharp
public virtual void DrawGUI()
```

### <a id="HarpEngine_Entity_OnRemove"></a> OnRemove\(\)

```csharp
public virtual void OnRemove()
```

### <a id="HarpEngine_Entity_Remove"></a> Remove\(\)

```csharp
public void Remove()
```

### <a id="HarpEngine_Entity_Update_System_Single_"></a> Update\(float\)

```csharp
public virtual void Update(float frameTime)
```

#### Parameters

`frameTime` [float](https://learn.microsoft.com/dotnet/api/system.single)

