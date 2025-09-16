# <a id="HarpEngine_Graphics_Primitives"></a> Class Primitives

Namespace: [HarpEngine.Graphics](HarpEngine.Graphics.md)  
Assembly: HarpEngine.dll  

```csharp
public static class Primitives
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Primitives](HarpEngine.Graphics.Primitives.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Methods

### <a id="HarpEngine_Graphics_Primitives_DrawArc_System_Numerics_Vector2_System_Single_System_Single_System_Single_System_Int32_HarpEngine_Graphics_Color_"></a> DrawArc\(Vector2, float, float, float, int, Color\)

```csharp
public static void DrawArc(Vector2 position, float radius, float startAngle, float endAngle, int segments, Color color)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`startAngle` [float](https://learn.microsoft.com/dotnet/api/system.single)

`endAngle` [float](https://learn.microsoft.com/dotnet/api/system.single)

`segments` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Primitives_DrawArcLines_System_Numerics_Vector2_System_Single_System_Single_System_Single_System_Int32_HarpEngine_Graphics_Color_"></a> DrawArcLines\(Vector2, float, float, float, int, Color\)

```csharp
public static void DrawArcLines(Vector2 position, float radius, float startAngle, float endAngle, int segments, Color color)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`startAngle` [float](https://learn.microsoft.com/dotnet/api/system.single)

`endAngle` [float](https://learn.microsoft.com/dotnet/api/system.single)

`segments` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Primitives_DrawBezier_System_Numerics_Vector2_System_Numerics_Vector2_System_Single_HarpEngine_Graphics_Color_"></a> DrawBezier\(Vector2, Vector2, float, Color\)

```csharp
public static void DrawBezier(Vector2 startPosition, Vector2 endPosition, float thickness, Color color)
```

#### Parameters

`startPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`endPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`thickness` [float](https://learn.microsoft.com/dotnet/api/system.single)

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Primitives_DrawCircle_System_Int32_System_Int32_System_Single_HarpEngine_Graphics_Color_"></a> DrawCircle\(int, int, float, Color\)

```csharp
public static extern void DrawCircle(int x, int y, float radius, Color color)
```

#### Parameters

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Primitives_DrawCircle_System_Int32_System_Int32_System_Single_HarpEngine_Graphics_Color_HarpEngine_Graphics_Color_"></a> DrawCircle\(int, int, float, Color, Color\)

```csharp
public static void DrawCircle(int x, int y, float radius, Color innerColor, Color outerColor)
```

#### Parameters

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`innerColor` [Color](HarpEngine.Graphics.Color.md)

`outerColor` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Primitives_DrawCircle_System_Numerics_Vector2_System_Single_HarpEngine_Graphics_Color_"></a> DrawCircle\(Vector2, float, Color\)

```csharp
public static void DrawCircle(Vector2 position, float radius, Color color)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Primitives_DrawCircleLines_System_Int32_System_Int32_System_Single_HarpEngine_Graphics_Color_"></a> DrawCircleLines\(int, int, float, Color\)

```csharp
public static extern void DrawCircleLines(int x, int y, float radius, Color color)
```

#### Parameters

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Primitives_DrawCircleLines_System_Numerics_Vector2_System_Single_HarpEngine_Graphics_Color_"></a> DrawCircleLines\(Vector2, float, Color\)

```csharp
public static void DrawCircleLines(Vector2 position, float radius, Color color)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Primitives_DrawEllipse_System_Int32_System_Int32_System_Single_System_Single_HarpEngine_Graphics_Color_"></a> DrawEllipse\(int, int, float, float, Color\)

```csharp
public static extern void DrawEllipse(int x, int y, float horizontalRadius, float verticalRadius, Color color)
```

#### Parameters

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`horizontalRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`verticalRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Primitives_DrawEllipseLines_System_Int32_System_Int32_System_Single_System_Single_HarpEngine_Graphics_Color_"></a> DrawEllipseLines\(int, int, float, float, Color\)

```csharp
public static extern void DrawEllipseLines(int x, int y, float horizontalRadius, float verticalRadius, Color color)
```

#### Parameters

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`horizontalRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`verticalRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Primitives_DrawLine_System_Int32_System_Int32_System_Int32_System_Int32_HarpEngine_Graphics_Color_"></a> DrawLine\(int, int, int, int, Color\)

```csharp
public static extern void DrawLine(int startX, int startY, int endX, int endY, Color color)
```

#### Parameters

`startX` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`startY` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`endX` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`endY` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Primitives_DrawLine_System_Numerics_Vector2_System_Numerics_Vector2_HarpEngine_Graphics_Color_"></a> DrawLine\(Vector2, Vector2, Color\)

```csharp
public static void DrawLine(Vector2 startPosition, Vector2 endPosition, Color color)
```

#### Parameters

`startPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`endPosition` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Primitives_DrawLine_System_Numerics_Vector2___HarpEngine_Graphics_Color_"></a> DrawLine\(Vector2\[\], Color\)

```csharp
public static void DrawLine(Vector2[] positions, Color color)
```

#### Parameters

`positions` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)\[\]

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Primitives_DrawPixel_System_Int32_System_Int32_HarpEngine_Graphics_Color_"></a> DrawPixel\(int, int, Color\)

```csharp
public static extern void DrawPixel(int x, int y, Color color)
```

#### Parameters

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Primitives_DrawPixel_System_Numerics_Vector2_HarpEngine_Graphics_Color_"></a> DrawPixel\(Vector2, Color\)

```csharp
public static void DrawPixel(Vector2 position, Color color)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Primitives_DrawPixelV_System_Numerics_Vector2_HarpEngine_Graphics_Color_"></a> DrawPixelV\(Vector2, Color\)

```csharp
public static extern void DrawPixelV(Vector2 position, Color color)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Primitives_DrawPolygon_System_Numerics_Vector2_System_Int32_System_Single_System_Single_HarpEngine_Graphics_Color_"></a> DrawPolygon\(Vector2, int, float, float, Color\)

```csharp
public static void DrawPolygon(Vector2 position, int sides, float radius, float rotation, Color color)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`sides` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`rotation` [float](https://learn.microsoft.com/dotnet/api/system.single)

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Primitives_DrawPolygonLines_System_Numerics_Vector2_System_Int32_System_Single_System_Single_HarpEngine_Graphics_Color_"></a> DrawPolygonLines\(Vector2, int, float, float, Color\)

```csharp
public static void DrawPolygonLines(Vector2 position, int sides, float radius, float rotation, Color color)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`sides` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`rotation` [float](https://learn.microsoft.com/dotnet/api/system.single)

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Primitives_DrawPolygonLines_System_Numerics_Vector2_System_Int32_System_Single_System_Single_System_Single_HarpEngine_Graphics_Color_"></a> DrawPolygonLines\(Vector2, int, float, float, float, Color\)

```csharp
public static void DrawPolygonLines(Vector2 position, int sides, float radius, float rotation, float lineThickness, Color color)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`sides` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`radius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`rotation` [float](https://learn.microsoft.com/dotnet/api/system.single)

`lineThickness` [float](https://learn.microsoft.com/dotnet/api/system.single)

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Primitives_DrawRectangle_System_Int32_System_Int32_System_Int32_System_Int32_HarpEngine_Graphics_Color_"></a> DrawRectangle\(int, int, int, int, Color\)

```csharp
public static extern void DrawRectangle(int x, int y, int width, int height, Color color)
```

#### Parameters

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Primitives_DrawRectangle_System_Numerics_Vector2_System_Numerics_Vector2_HarpEngine_Graphics_Color_"></a> DrawRectangle\(Vector2, Vector2, Color\)

```csharp
public static void DrawRectangle(Vector2 position, Vector2 size, Color color)
```

#### Parameters

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`size` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Primitives_DrawRectangle_HarpEngine_Graphics_Rectangle_HarpEngine_Graphics_Color_"></a> DrawRectangle\(Rectangle, Color\)

```csharp
public static void DrawRectangle(Rectangle rectangle, Color color)
```

#### Parameters

`rectangle` [Rectangle](HarpEngine.Graphics.Rectangle.md)

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Primitives_DrawRectangle_HarpEngine_Graphics_Rectangle_System_Numerics_Vector2_System_Single_HarpEngine_Graphics_Color_"></a> DrawRectangle\(Rectangle, Vector2, float, Color\)

```csharp
public static void DrawRectangle(Rectangle rectangle, Vector2 origin, float rotation, Color color)
```

#### Parameters

`rectangle` [Rectangle](HarpEngine.Graphics.Rectangle.md)

`origin` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`rotation` [float](https://learn.microsoft.com/dotnet/api/system.single)

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Primitives_DrawRectangleGradient_HarpEngine_Graphics_Rectangle_HarpEngine_Graphics_Color_HarpEngine_Graphics_Color_HarpEngine_Graphics_Color_HarpEngine_Graphics_Color_"></a> DrawRectangleGradient\(Rectangle, Color, Color, Color, Color\)

```csharp
public static void DrawRectangleGradient(Rectangle rectangle, Color topLeftColor, Color bottomLeftColor, Color topRightColor, Color bottomRightColor)
```

#### Parameters

`rectangle` [Rectangle](HarpEngine.Graphics.Rectangle.md)

`topLeftColor` [Color](HarpEngine.Graphics.Color.md)

`bottomLeftColor` [Color](HarpEngine.Graphics.Color.md)

`topRightColor` [Color](HarpEngine.Graphics.Color.md)

`bottomRightColor` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Primitives_DrawRectangleGradientHorizontal_System_Int32_System_Int32_System_Int32_System_Int32_HarpEngine_Graphics_Color_HarpEngine_Graphics_Color_"></a> DrawRectangleGradientHorizontal\(int, int, int, int, Color, Color\)

```csharp
public static void DrawRectangleGradientHorizontal(int x, int y, int width, int height, Color leftColor, Color rightColor)
```

#### Parameters

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`leftColor` [Color](HarpEngine.Graphics.Color.md)

`rightColor` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Primitives_DrawRectangleGradientVertical_System_Int32_System_Int32_System_Int32_System_Int32_HarpEngine_Graphics_Color_HarpEngine_Graphics_Color_"></a> DrawRectangleGradientVertical\(int, int, int, int, Color, Color\)

```csharp
public static void DrawRectangleGradientVertical(int x, int y, int width, int height, Color topColor, Color bottomColor)
```

#### Parameters

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`topColor` [Color](HarpEngine.Graphics.Color.md)

`bottomColor` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Primitives_DrawRectangleLines_System_Int32_System_Int32_System_Int32_System_Int32_HarpEngine_Graphics_Color_"></a> DrawRectangleLines\(int, int, int, int, Color\)

```csharp
public static extern void DrawRectangleLines(int x, int y, int width, int height, Color color)
```

#### Parameters

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Primitives_DrawRectangleLines_HarpEngine_Graphics_Rectangle_System_Single_HarpEngine_Graphics_Color_"></a> DrawRectangleLines\(Rectangle, float, Color\)

```csharp
public static void DrawRectangleLines(Rectangle rectangle, float lineThickness, Color color)
```

#### Parameters

`rectangle` [Rectangle](HarpEngine.Graphics.Rectangle.md)

`lineThickness` [float](https://learn.microsoft.com/dotnet/api/system.single)

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Primitives_DrawRectangleRounded_HarpEngine_Graphics_Rectangle_System_Single_System_Int32_HarpEngine_Graphics_Color_"></a> DrawRectangleRounded\(Rectangle, float, int, Color\)

```csharp
public static extern void DrawRectangleRounded(Rectangle rectangle, float roundness, int segments, Color color)
```

#### Parameters

`rectangle` [Rectangle](HarpEngine.Graphics.Rectangle.md)

`roundness` [float](https://learn.microsoft.com/dotnet/api/system.single)

`segments` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Primitives_DrawRectangleRoundedLines_HarpEngine_Graphics_Rectangle_System_Single_System_Int32_HarpEngine_Graphics_Color_"></a> DrawRectangleRoundedLines\(Rectangle, float, int, Color\)

```csharp
public static extern void DrawRectangleRoundedLines(Rectangle rectangle, float roundness, int segments, Color color)
```

#### Parameters

`rectangle` [Rectangle](HarpEngine.Graphics.Rectangle.md)

`roundness` [float](https://learn.microsoft.com/dotnet/api/system.single)

`segments` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Primitives_DrawRectangleRoundedLines_HarpEngine_Graphics_Rectangle_System_Single_System_Int32_System_Single_HarpEngine_Graphics_Color_"></a> DrawRectangleRoundedLines\(Rectangle, float, int, float, Color\)

```csharp
public static void DrawRectangleRoundedLines(Rectangle rectangle, float roundness, int segments, float lineThickness, Color color)
```

#### Parameters

`rectangle` [Rectangle](HarpEngine.Graphics.Rectangle.md)

`roundness` [float](https://learn.microsoft.com/dotnet/api/system.single)

`segments` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`lineThickness` [float](https://learn.microsoft.com/dotnet/api/system.single)

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Primitives_DrawRing_System_Numerics_Vector2_System_Single_System_Single_System_Single_System_Single_System_Int32_HarpEngine_Graphics_Color_"></a> DrawRing\(Vector2, float, float, float, float, int, Color\)

```csharp
public static extern void DrawRing(Vector2 center, float innerRadius, float outerRadius, float startAngle, float endAngle, int segments, Color color)
```

#### Parameters

`center` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`innerRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`outerRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`startAngle` [float](https://learn.microsoft.com/dotnet/api/system.single)

`endAngle` [float](https://learn.microsoft.com/dotnet/api/system.single)

`segments` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Primitives_DrawRingLines_System_Numerics_Vector2_System_Single_System_Single_System_Single_System_Single_System_Int32_HarpEngine_Graphics_Color_"></a> DrawRingLines\(Vector2, float, float, float, float, int, Color\)

```csharp
public static extern void DrawRingLines(Vector2 center, float innerRadius, float outerRadius, float startAngle, float endAngle, int segments, Color color)
```

#### Parameters

`center` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`innerRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`outerRadius` [float](https://learn.microsoft.com/dotnet/api/system.single)

`startAngle` [float](https://learn.microsoft.com/dotnet/api/system.single)

`endAngle` [float](https://learn.microsoft.com/dotnet/api/system.single)

`segments` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Primitives_DrawTriangle_System_Numerics_Vector2_System_Numerics_Vector2_System_Numerics_Vector2_HarpEngine_Graphics_Color_"></a> DrawTriangle\(Vector2, Vector2, Vector2, Color\)

```csharp
public static extern void DrawTriangle(Vector2 cornerOne, Vector2 cornerTwo, Vector2 cornerThree, Color color)
```

#### Parameters

`cornerOne` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`cornerTwo` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`cornerThree` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Primitives_DrawTriangleFan_System_Numerics_Vector2___System_Int32_HarpEngine_Graphics_Color_"></a> DrawTriangleFan\(Vector2\[\], int, Color\)

```csharp
public static extern void DrawTriangleFan(Vector2[] positions, int positionCount, Color color)
```

#### Parameters

`positions` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)\[\]

`positionCount` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Primitives_DrawTriangleLines_System_Numerics_Vector2_System_Numerics_Vector2_System_Numerics_Vector2_HarpEngine_Graphics_Color_"></a> DrawTriangleLines\(Vector2, Vector2, Vector2, Color\)

```csharp
public static extern void DrawTriangleLines(Vector2 cornerOne, Vector2 cornerTwo, Vector2 cornerThree, Color color)
```

#### Parameters

`cornerOne` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`cornerTwo` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`cornerThree` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Primitives_DrawTriangleStrip_System_Numerics_Vector2___System_Int32_HarpEngine_Graphics_Color_"></a> DrawTriangleStrip\(Vector2\[\], int, Color\)

```csharp
public static extern void DrawTriangleStrip(Vector2[] positions, int positionCount, Color color)
```

#### Parameters

`positions` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)\[\]

`positionCount` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`color` [Color](HarpEngine.Graphics.Color.md)

