# <a id="HarpEngine_Graphics_Text"></a> Class Text

Namespace: [HarpEngine.Graphics](HarpEngine.Graphics.md)  
Assembly: HarpEngine.dll  

```csharp
public static class Text
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Text](HarpEngine.Graphics.Text.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Methods

### <a id="HarpEngine_Graphics_Text_Draw_System_String_System_Int32_System_Int32_System_Int32_HarpEngine_Graphics_Color_"></a> Draw\(string, int, int, int, Color\)

```csharp
public static void Draw(string text, int x, int y, int fontSize, Color color)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`fontSize` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Text_Draw_System_String_System_Numerics_Vector2_System_Int32_HarpEngine_Graphics_Color_"></a> Draw\(string, Vector2, int, Color\)

```csharp
public static void Draw(string text, Vector2 position, int fontSize, Color color)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`fontSize` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`color` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Text_Draw_HarpEngine_Graphics_Font_System_String_System_Numerics_Vector2_System_Single_System_Single_HarpEngine_Graphics_Color_"></a> Draw\(Font, string, Vector2, float, float, Color\)

```csharp
public static void Draw(Font font, string text, Vector2 position, float fontSize, float spacing, Color tint)
```

#### Parameters

`font` [Font](HarpEngine.Graphics.Font.md)

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`fontSize` [float](https://learn.microsoft.com/dotnet/api/system.single)

`spacing` [float](https://learn.microsoft.com/dotnet/api/system.single)

`tint` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Text_Draw_HarpEngine_Graphics_Font_System_String_System_Numerics_Vector2_System_Numerics_Vector2_System_Single_System_Single_System_Single_HarpEngine_Graphics_Color_"></a> Draw\(Font, string, Vector2, Vector2, float, float, float, Color\)

```csharp
public static void Draw(Font font, string text, Vector2 position, Vector2 origin, float rotation, float fontSize, float spacing, Color tint)
```

#### Parameters

`font` [Font](HarpEngine.Graphics.Font.md)

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

`position` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`origin` [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

`rotation` [float](https://learn.microsoft.com/dotnet/api/system.single)

`fontSize` [float](https://learn.microsoft.com/dotnet/api/system.single)

`spacing` [float](https://learn.microsoft.com/dotnet/api/system.single)

`tint` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Text_MeasureSize_HarpEngine_Graphics_Font_System_String_System_Single_System_Single_"></a> MeasureSize\(Font, string, float, float\)

```csharp
public static Vector2 MeasureSize(Font font, string text, float fontSize, float spacing)
```

#### Parameters

`font` [Font](HarpEngine.Graphics.Font.md)

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

`fontSize` [float](https://learn.microsoft.com/dotnet/api/system.single)

`spacing` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="HarpEngine_Graphics_Text_MeasureWidth_System_String_System_Int32_"></a> MeasureWidth\(string, int\)

```csharp
public static int MeasureWidth(string text, int fontSize)
```

#### Parameters

`text` [string](https://learn.microsoft.com/dotnet/api/system.string)

`fontSize` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="HarpEngine_Graphics_Text_SetLineSpacing_System_Int32_"></a> SetLineSpacing\(int\)

```csharp
public static void SetLineSpacing(int spacing)
```

#### Parameters

`spacing` [int](https://learn.microsoft.com/dotnet/api/system.int32)

