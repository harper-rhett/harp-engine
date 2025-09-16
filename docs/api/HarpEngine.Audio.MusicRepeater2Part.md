# <a id="HarpEngine_Audio_MusicRepeater2Part"></a> Class MusicRepeater2Part

Namespace: [HarpEngine.Audio](HarpEngine.Audio.md)  
Assembly: HarpEngine.dll  

```csharp
public class MusicRepeater2Part : Entity
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](HarpEngine.Entity.md) ← 
[MusicRepeater2Part](HarpEngine.Audio.MusicRepeater2Part.md)

#### Inherited Members

[Entity.scene](HarpEngine.Entity.md\#HarpEngine\_Entity\_scene), 
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
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="HarpEngine_Audio_MusicRepeater2Part__ctor_HarpEngine_Scene_HarpEngine_Audio_Music_HarpEngine_Audio_Music_"></a> MusicRepeater2Part\(Scene, Music, Music\)

```csharp
public MusicRepeater2Part(Scene scene, Music initialMusic, Music repeatedMusic)
```

#### Parameters

`scene` [Scene](HarpEngine.Scene.md)

`initialMusic` [Music](HarpEngine.Audio.Music.md)

`repeatedMusic` [Music](HarpEngine.Audio.Music.md)

## Methods

### <a id="HarpEngine_Audio_MusicRepeater2Part_Pause"></a> Pause\(\)

```csharp
public void Pause()
```

### <a id="HarpEngine_Audio_MusicRepeater2Part_Resume"></a> Resume\(\)

```csharp
public void Resume()
```

### <a id="HarpEngine_Audio_MusicRepeater2Part_Start"></a> Start\(\)

```csharp
public void Start()
```

### <a id="HarpEngine_Audio_MusicRepeater2Part_Stop"></a> Stop\(\)

```csharp
public void Stop()
```

### <a id="HarpEngine_Audio_MusicRepeater2Part_Update_System_Single_"></a> Update\(float\)

```csharp
public override void Update(float frameTime)
```

#### Parameters

`frameTime` [float](https://learn.microsoft.com/dotnet/api/system.single)

