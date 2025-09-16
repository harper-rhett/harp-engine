# <a id="HarpEngine_Graphics_Spline"></a> Class Spline

Namespace: [HarpEngine.Graphics](HarpEngine.Graphics.md)  
Assembly: HarpEngine.dll  

```csharp
public static class Spline
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Spline](HarpEngine.Graphics.Spline.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Methods

### <a id="HarpEngine_Graphics_Spline_DrawBasis_System_Numerics_Vector2___System_Single_HarpEngine_Graphics_Color_"></a> DrawBasis\(Vector2\[\], float, Color\)

```csharp
public static void DrawBasis(Vector2[] positions, float thickness, Color color)
```

#### Parameters

`positions` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)\[\]

`thickness` [float](https://learn.microsoft.com/dotnet/api/system.single)

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Spline_DrawBezierCubic_System_Numerics_Vector2___System_Single_HarpEngine_Graphics_Color_"></a> DrawBezierCubic\(Vector2\[\], float, Color\)

```csharp
public static void DrawBezierCubic(Vector2[] positions, float thickness, Color color)
```

#### Parameters

`positions` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)\[\]

`thickness` [float](https://learn.microsoft.com/dotnet/api/system.single)

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Spline_DrawBezierQuadratic_System_Numerics_Vector2___System_Single_HarpEngine_Graphics_Color_"></a> DrawBezierQuadratic\(Vector2\[\], float, Color\)

```csharp
public static void DrawBezierQuadratic(Vector2[] positions, float thickness, Color color)
```

#### Parameters

`positions` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)\[\]

`thickness` [float](https://learn.microsoft.com/dotnet/api/system.single)

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Spline_DrawCatmullRom_System_Numerics_Vector2___System_Single_HarpEngine_Graphics_Color_"></a> DrawCatmullRom\(Vector2\[\], float, Color\)

```csharp
public static void DrawCatmullRom(Vector2[] positions, float thickness, Color color)
```

#### Parameters

`positions` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)\[\]

`thickness` [float](https://learn.microsoft.com/dotnet/api/system.single)

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Spline_DrawLinear_System_Numerics_Vector2___System_Single_HarpEngine_Graphics_Color_"></a> DrawLinear\(Vector2\[\], float, Color\)

```csharp
public static void DrawLinear(Vector2[] positions, float thickness, Color color)
```

#### Parameters

`positions` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)\[\]

`thickness` [float](https://learn.microsoft.com/dotnet/api/system.single)

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Spline_DrawSegmentBasis_System_Numerics_Vector2_System_Numerics_Vector2_System_Numerics_Vector2_System_Numerics_Vector2_System_Single_HarpEngine_Graphics_Color_"></a> DrawSegmentBasis\(Vector2, Vector2, Vector2, Vector2, float, Color\)

```csharp
public static void DrawSegmentBasis(Vector2 positionOne, Vector2 positionTwo, Vector2 positionThree, Vector2 positionFour, float thickness, Color color)
```

#### Parameters

`positionOne` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`positionTwo` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`positionThree` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`positionFour` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`thickness` [float](https://learn.microsoft.com/dotnet/api/system.single)

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Spline_DrawSegmentBezierCubic_System_Numerics_Vector2_System_Numerics_Vector2_System_Numerics_Vector2_System_Numerics_Vector2_System_Single_HarpEngine_Graphics_Color_"></a> DrawSegmentBezierCubic\(Vector2, Vector2, Vector2, Vector2, float, Color\)

```csharp
public static void DrawSegmentBezierCubic(Vector2 positionOne, Vector2 controlPositionOne, Vector2 controlPositionTwo, Vector2 positionTwo, float thickness, Color color)
```

#### Parameters

`positionOne` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`controlPositionOne` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`controlPositionTwo` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`positionTwo` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`thickness` [float](https://learn.microsoft.com/dotnet/api/system.single)

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Spline_DrawSegmentBezierQuadratic_System_Numerics_Vector2_System_Numerics_Vector2_System_Numerics_Vector2_System_Single_HarpEngine_Graphics_Color_"></a> DrawSegmentBezierQuadratic\(Vector2, Vector2, Vector2, float, Color\)

```csharp
public static void DrawSegmentBezierQuadratic(Vector2 positionOne, Vector2 controlPosition, Vector2 positionTwo, float thickness, Color color)
```

#### Parameters

`positionOne` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`controlPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`positionTwo` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`thickness` [float](https://learn.microsoft.com/dotnet/api/system.single)

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Spline_DrawSegmentCatmullRom_System_Numerics_Vector2_System_Numerics_Vector2_System_Numerics_Vector2_System_Numerics_Vector2_System_Single_HarpEngine_Graphics_Color_"></a> DrawSegmentCatmullRom\(Vector2, Vector2, Vector2, Vector2, float, Color\)

```csharp
public static void DrawSegmentCatmullRom(Vector2 positionOne, Vector2 positionTwo, Vector2 positionThree, Vector2 positionFour, float thickness, Color color)
```

#### Parameters

`positionOne` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`positionTwo` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`positionThree` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`positionFour` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`thickness` [float](https://learn.microsoft.com/dotnet/api/system.single)

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Spline_DrawSegmentLinear_System_Numerics_Vector2_System_Numerics_Vector2_System_Single_HarpEngine_Graphics_Color_"></a> DrawSegmentLinear\(Vector2, Vector2, float, Color\)

```csharp
public static void DrawSegmentLinear(Vector2 startPosition, Vector2 endPosition, float thickness, Color color)
```

#### Parameters

`startPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`endPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`thickness` [float](https://learn.microsoft.com/dotnet/api/system.single)

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Spline_GetPointBasis_System_Numerics_Vector2_System_Numerics_Vector2_System_Numerics_Vector2_System_Numerics_Vector2_System_Single_"></a> GetPointBasis\(Vector2, Vector2, Vector2, Vector2, float\)

```csharp
public static Vector2 GetPointBasis(Vector2 positionOne, Vector2 positionTwo, Vector2 positionThree, Vector2 positionFour, float progress)
```

#### Parameters

`positionOne` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`positionTwo` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`positionThree` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`positionFour` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`progress` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="HarpEngine_Graphics_Spline_GetPointBezierCubic_System_Numerics_Vector2_System_Numerics_Vector2_System_Numerics_Vector2_System_Numerics_Vector2_System_Single_"></a> GetPointBezierCubic\(Vector2, Vector2, Vector2, Vector2, float\)

```csharp
public static Vector2 GetPointBezierCubic(Vector2 positionOne, Vector2 controlPositionOne, Vector2 controlPositionTwo, Vector2 positionTwo, float progress)
```

#### Parameters

`positionOne` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`controlPositionOne` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`controlPositionTwo` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`positionTwo` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`progress` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="HarpEngine_Graphics_Spline_GetPointBezierQuad_System_Numerics_Vector2_System_Numerics_Vector2_System_Numerics_Vector2_System_Single_"></a> GetPointBezierQuad\(Vector2, Vector2, Vector2, float\)

```csharp
public static Vector2 GetPointBezierQuad(Vector2 positionOne, Vector2 controlPosition, Vector2 positionTwo, float progress)
```

#### Parameters

`positionOne` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`controlPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`positionTwo` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`progress` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="HarpEngine_Graphics_Spline_GetPointCatmullRom_System_Numerics_Vector2_System_Numerics_Vector2_System_Numerics_Vector2_System_Numerics_Vector2_System_Single_"></a> GetPointCatmullRom\(Vector2, Vector2, Vector2, Vector2, float\)

```csharp
public static Vector2 GetPointCatmullRom(Vector2 positionOne, Vector2 positionTwo, Vector2 positionThree, Vector2 positionFour, float progress)
```

#### Parameters

`positionOne` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`positionTwo` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`positionThree` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`positionFour` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`progress` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="HarpEngine_Graphics_Spline_GetPointLinear_System_Numerics_Vector2_System_Numerics_Vector2_System_Single_"></a> GetPointLinear\(Vector2, Vector2, float\)

```csharp
public static Vector2 GetPointLinear(Vector2 startPosition, Vector2 endPosition, float progress)
```

#### Parameters

`startPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`endPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`progress` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

