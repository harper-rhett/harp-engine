# <a id="HarpEngine_Camera2D"></a> Class Camera2D

Namespace: [HarpEngine](HarpEngine.md)  
Assembly: HarpEngine.dll  

```csharp
public class Camera2D : Camera
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](HarpEngine.Entity.md) ← 
[Camera](HarpEngine.Camera.md) ← 
[Camera2D](HarpEngine.Camera2D.md)

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

### <a id="HarpEngine_Camera2D__ctor_HarpEngine_Scene_"></a> Camera2D\(Scene\)

```csharp
public Camera2D(Scene scene)
```

#### Parameters

`scene` [Scene](HarpEngine.Scene.md)

## Fields

### <a id="HarpEngine_Camera2D_Transform"></a> Transform

```csharp
public Transform2D Transform
```

#### Field Value

 [Transform2D](HarpEngine.Utilities.Transform2D.md)

## Properties

### <a id="HarpEngine_Camera2D_MouseWorldX"></a> MouseWorldX

```csharp
public float MouseWorldX { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="HarpEngine_Camera2D_MouseWorldY"></a> MouseWorldY

```csharp
public float MouseWorldY { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="HarpEngine_Camera2D_TransitionLocalPosition_System_Numerics_Vector2_System_Single_"></a> TransitionLocalPosition\(Vector2, float\)

```csharp
public void TransitionLocalPosition(Vector2 targetPosition, float seconds)
```

#### Parameters

`targetPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`seconds` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="HarpEngine_Camera2D_TransitionLocalRotation_System_Single_System_Single_"></a> TransitionLocalRotation\(float, float\)

```csharp
public void TransitionLocalRotation(float targetRotation, float seconds)
```

#### Parameters

`targetRotation` [float](https://learn.microsoft.com/dotnet/api/system.single)

`seconds` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="HarpEngine_Camera2D_TransitionWorldPosition_System_Numerics_Vector2_System_Single_"></a> TransitionWorldPosition\(Vector2, float\)

```csharp
public void TransitionWorldPosition(Vector2 targetPosition, float seconds)
```

#### Parameters

`targetPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`seconds` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="HarpEngine_Camera2D_TransitionWorldRotation_System_Single_System_Single_"></a> TransitionWorldRotation\(float, float\)

```csharp
public void TransitionWorldRotation(float targetRotation, float seconds)
```

#### Parameters

`targetRotation` [float](https://learn.microsoft.com/dotnet/api/system.single)

`seconds` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="HarpEngine_Camera2D_Update_System_Single_"></a> Update\(float\)

```csharp
public override void Update(float frameTime)
```

#### Parameters

`frameTime` [float](https://learn.microsoft.com/dotnet/api/system.single)

