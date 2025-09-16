# <a id="HarpEngine_Utilities_Transform2D"></a> Class Transform2D

Namespace: [HarpEngine.Utilities](HarpEngine.Utilities.md)  
Assembly: HarpEngine.dll  

```csharp
public class Transform2D
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Transform2D](HarpEngine.Utilities.Transform2D.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Fields

### <a id="HarpEngine_Utilities_Transform2D_LocalPosition"></a> LocalPosition

```csharp
public Vector2 LocalPosition
```

#### Field Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="HarpEngine_Utilities_Transform2D_LocalRotation"></a> LocalRotation

```csharp
public float LocalRotation
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="HarpEngine_Utilities_Transform2D_Parent"></a> Parent

```csharp
public Transform2D Parent
```

#### Field Value

 [Transform2D](HarpEngine.Utilities.Transform2D.md)

## Properties

### <a id="HarpEngine_Utilities_Transform2D_Matrix"></a> Matrix

```csharp
public Matrix3x2 Matrix { get; }
```

#### Property Value

 [Matrix3x2](https://learn.microsoft.com/dotnet/api/system.numerics.matrix3x2)

### <a id="HarpEngine_Utilities_Transform2D_MatrixInverse"></a> MatrixInverse

```csharp
public Matrix3x2 MatrixInverse { get; }
```

#### Property Value

 [Matrix3x2](https://learn.microsoft.com/dotnet/api/system.numerics.matrix3x2)

### <a id="HarpEngine_Utilities_Transform2D_WorldPosition"></a> WorldPosition

```csharp
public Vector2 WorldPosition { get; set; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="HarpEngine_Utilities_Transform2D_WorldRotation"></a> WorldRotation

```csharp
public float WorldRotation { get; set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

