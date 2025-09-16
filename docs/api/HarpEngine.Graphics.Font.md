# <a id="HarpEngine_Graphics_Font"></a> Struct Font

Namespace: [HarpEngine.Graphics](HarpEngine.Graphics.md)  
Assembly: HarpEngine.dll  

```csharp
public struct Font : IDisposable
```

#### Implements

[IDisposable](https://learn.microsoft.com/dotnet/api/system.idisposable)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Fields

### <a id="HarpEngine_Graphics_Font_BaseSize"></a> BaseSize

```csharp
public int BaseSize
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="HarpEngine_Graphics_Font_GlyphCount"></a> GlyphCount

```csharp
public int GlyphCount
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="HarpEngine_Graphics_Font_GlyphPadding"></a> GlyphPadding

```csharp
public int GlyphPadding
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="HarpEngine_Graphics_Font_Glyphs"></a> Glyphs

```csharp
public GlyphInfo* Glyphs
```

#### Field Value

 [GlyphInfo](HarpEngine.Graphics.GlyphInfo.md)\*

### <a id="HarpEngine_Graphics_Font_Recs"></a> Recs

```csharp
public Rectangle* Recs
```

#### Field Value

 [Rectangle](HarpEngine.Graphics.Rectangle.md)\*

### <a id="HarpEngine_Graphics_Font_Texture"></a> Texture

```csharp
public Texture Texture
```

#### Field Value

 [Texture](HarpEngine.Graphics.Texture.md)

## Properties

### <a id="HarpEngine_Graphics_Font_Default"></a> Default

```csharp
public static Font Default { get; }
```

#### Property Value

 [Font](HarpEngine.Graphics.Font.md)

### <a id="HarpEngine_Graphics_Font_IsValid"></a> IsValid

```csharp
public bool IsValid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="HarpEngine_Graphics_Font_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="HarpEngine_Graphics_Font_Load_System_String_"></a> Load\(string\)

```csharp
public static Font Load(string fileName)
```

#### Parameters

`fileName` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [Font](HarpEngine.Graphics.Font.md)

### <a id="HarpEngine_Graphics_Font_Load_HarpEngine_Graphics_Image_HarpEngine_Graphics_Color_System_Int32_"></a> Load\(Image, Color, int\)

```csharp
public static Font Load(Image image, Color key, int firstCharacter)
```

#### Parameters

`image` [Image](HarpEngine.Graphics.Image.md)

`key` [Color](HarpEngine.Graphics.Color.md)

`firstCharacter` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [Font](HarpEngine.Graphics.Font.md)

