# <a id="HarpEngine_Scene"></a> Class Scene

Namespace: [HarpEngine](HarpEngine.md)  
Assembly: HarpEngine.dll  

```csharp
public class Scene
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Scene](HarpEngine.Scene.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="HarpEngine_Scene__ctor"></a> Scene\(\)

```csharp
public Scene()
```

### <a id="HarpEngine_Scene__ctor_HarpEngine_Graphics_Color_"></a> Scene\(Color\)

```csharp
public Scene(Color backgroundColor)
```

#### Parameters

`backgroundColor` [Color](HarpEngine.Graphics.Color.md)

## Fields

### <a id="HarpEngine_Scene_BackgroundColor"></a> BackgroundColor

```csharp
public Color BackgroundColor
```

#### Field Value

 [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Scene_Camera"></a> Camera

```csharp
public Camera Camera
```

#### Field Value

 [Camera](HarpEngine.Camera.md)

### <a id="HarpEngine_Scene_IsPaused"></a> IsPaused

If the update loop is paused. The draw loop is unaffected/

```csharp
public bool IsPaused
```

#### Field Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="HarpEngine_Scene_TimeModifier"></a> TimeModifier

```csharp
public float TimeModifier
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Properties

### <a id="HarpEngine_Scene_Entities"></a> Entities

```csharp
public Entities Entities { get; }
```

#### Property Value

 [Entities](HarpEngine.Entities.md)

### <a id="HarpEngine_Scene_Time"></a> Time

Seconds since creation that this world has been unpaused.

```csharp
public float Time { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="HarpEngine_Scene_Draw"></a> Draw\(\)

```csharp
public void Draw()
```

### <a id="HarpEngine_Scene_Update_System_Single_"></a> Update\(float\)

```csharp
public void Update(float frameTime)
```

#### Parameters

`frameTime` [float](https://learn.microsoft.com/dotnet/api/system.single)

