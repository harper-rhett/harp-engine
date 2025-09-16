# <a id="HarpEngine_Shapes_Polygon"></a> Class Polygon

Namespace: [HarpEngine.Shapes](HarpEngine.Shapes.md)  
Assembly: HarpEngine.dll  

```csharp
public class Polygon : Entity
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Entity](HarpEngine.Entity.md) ← 
[Polygon](HarpEngine.Shapes.Polygon.md)

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

### <a id="HarpEngine_Shapes_Polygon__ctor_HarpEngine_Scene_System_Single_System_Int32_HarpEngine_Graphics_Color_"></a> Polygon\(Scene, float, int, Color\)

```csharp
public Polygon(Scene scene, float radius, int sideCount, Color color)
```

#### Parameters

`scene` [Scene](HarpEngine.Scene.md)

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`sideCount` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`color` [Color](HarpEngine.Graphics.Color.md)

## Fields

### <a id="HarpEngine_Shapes_Polygon_Color"></a> Color

```csharp
public Color Color
```

#### Field Value

 [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Shapes_Polygon_Radius"></a> Radius

```csharp
public float Radius
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="HarpEngine_Shapes_Polygon_SideCount"></a> SideCount

```csharp
public int SideCount
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="HarpEngine_Shapes_Polygon_Transform"></a> Transform

```csharp
public Transform2D Transform
```

#### Field Value

 [Transform2D](HarpEngine.Utilities.Transform2D.md)

## Methods

### <a id="HarpEngine_Shapes_Polygon_Draw"></a> Draw\(\)

```csharp
public override void Draw()
```

