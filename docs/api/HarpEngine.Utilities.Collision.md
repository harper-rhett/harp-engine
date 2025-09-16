# <a id="HarpEngine_Utilities_Collision"></a> Class Collision

Namespace: [HarpEngine.Utilities](HarpEngine.Utilities.md)  
Assembly: HarpEngine.dll  

```csharp
public static class Collision
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Collision](HarpEngine.Utilities.Collision.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Methods

### <a id="HarpEngine_Utilities_Collision_CircleInCircleSquared_System_Numerics_Vector2_System_Single_System_Numerics_Vector2_System_Single_"></a> CircleInCircleSquared\(Vector2, float, Vector2, float\)

```csharp
public static bool CircleInCircleSquared(Vector2 positionA, float radiusSquaredA, Vector2 positionB, float radiusSquaredB)
```

#### Parameters

`positionA` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`radiusSquaredA` [float](https://learn.microsoft.com/dotnet/api/system.single)

`positionB` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`radiusSquaredB` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="HarpEngine_Utilities_Collision_CircleOnCircleSquared_System_Numerics_Vector2_System_Single_System_Numerics_Vector2_System_Single_"></a> CircleOnCircleSquared\(Vector2, float, Vector2, float\)

```csharp
public static bool CircleOnCircleSquared(Vector2 positionA, float radiusSquaredA, Vector2 positionB, float radiusSquaredB)
```

#### Parameters

`positionA` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`radiusSquaredA` [float](https://learn.microsoft.com/dotnet/api/system.single)

`positionB` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`radiusSquaredB` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="HarpEngine_Utilities_Collision_PointInCircleSquared_System_Numerics_Vector2_System_Numerics_Vector2_System_Single_"></a> PointInCircleSquared\(Vector2, Vector2, float\)

```csharp
public static bool PointInCircleSquared(Vector2 pointPosition, Vector2 circlePosition, float radiusSquared)
```

#### Parameters

`pointPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`circlePosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`radiusSquared` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

