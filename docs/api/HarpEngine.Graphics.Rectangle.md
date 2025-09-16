# <a id="HarpEngine_Graphics_Rectangle"></a> Struct Rectangle

Namespace: [HarpEngine.Graphics](HarpEngine.Graphics.md)  
Assembly: HarpEngine.dll  

```csharp
public struct Rectangle
```

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="HarpEngine_Graphics_Rectangle__ctor_System_Single_System_Single_System_Single_System_Single_"></a> Rectangle\(float, float, float, float\)

```csharp
public Rectangle(float x, float y, float width, float height)
```

#### Parameters

`x` [float](https://learn.microsoft.com/dotnet/api/system.single)

`y` [float](https://learn.microsoft.com/dotnet/api/system.single)

`width` [float](https://learn.microsoft.com/dotnet/api/system.single)

`height` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="HarpEngine_Graphics_Rectangle__ctor_System_Numerics_Vector2_System_Single_System_Single_"></a> Rectangle\(Vector2, float, float\)

```csharp
public Rectangle(Vector2 position, float width, float height)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`width` [float](https://learn.microsoft.com/dotnet/api/system.single)

`height` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="HarpEngine_Graphics_Rectangle__ctor_System_Single_System_Single_System_Numerics_Vector2_"></a> Rectangle\(float, float, Vector2\)

```csharp
public Rectangle(float x, float y, Vector2 size)
```

#### Parameters

`x` [float](https://learn.microsoft.com/dotnet/api/system.single)

`y` [float](https://learn.microsoft.com/dotnet/api/system.single)

`size` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="HarpEngine_Graphics_Rectangle__ctor_System_Numerics_Vector2_System_Numerics_Vector2_"></a> Rectangle\(Vector2, Vector2\)

```csharp
public Rectangle(Vector2 position, Vector2 size)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`size` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

## Fields

### <a id="HarpEngine_Graphics_Rectangle_Height"></a> Height

```csharp
public float Height
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="HarpEngine_Graphics_Rectangle_Width"></a> Width

```csharp
public float Width
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="HarpEngine_Graphics_Rectangle_X"></a> X

```csharp
public float X
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="HarpEngine_Graphics_Rectangle_Y"></a> Y

```csharp
public float Y
```

#### Field Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Properties

### <a id="HarpEngine_Graphics_Rectangle_Position"></a> Position

```csharp
public Vector2 Position { readonly get; set; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="HarpEngine_Graphics_Rectangle_Size"></a> Size

```csharp
public Vector2 Size { readonly get; set; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

## Methods

### <a id="HarpEngine_Graphics_Rectangle_ToString"></a> ToString\(\)

Returns the fully qualified type name of this instance.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

The fully qualified type name.

