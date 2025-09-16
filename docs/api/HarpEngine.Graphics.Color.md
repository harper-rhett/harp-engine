# <a id="HarpEngine_Graphics_Color"></a> Struct Color

Namespace: [HarpEngine.Graphics](HarpEngine.Graphics.md)  
Assembly: HarpEngine.dll  

```csharp
public struct Color
```

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Constructors

### <a id="HarpEngine_Graphics_Color__ctor_System_Byte_System_Byte_System_Byte_System_Byte_"></a> Color\(byte, byte, byte, byte\)

```csharp
public Color(byte r, byte g, byte b, byte a)
```

#### Parameters

`r` [byte](https://learn.microsoft.com/dotnet/api/system.byte)

`g` [byte](https://learn.microsoft.com/dotnet/api/system.byte)

`b` [byte](https://learn.microsoft.com/dotnet/api/system.byte)

`a` [byte](https://learn.microsoft.com/dotnet/api/system.byte)

### <a id="HarpEngine_Graphics_Color__ctor_System_Byte_System_Byte_System_Byte_"></a> Color\(byte, byte, byte\)

```csharp
public Color(byte r, byte g, byte b)
```

#### Parameters

`r` [byte](https://learn.microsoft.com/dotnet/api/system.byte)

`g` [byte](https://learn.microsoft.com/dotnet/api/system.byte)

`b` [byte](https://learn.microsoft.com/dotnet/api/system.byte)

### <a id="HarpEngine_Graphics_Color__ctor_System_Int32_System_Int32_System_Int32_System_Int32_"></a> Color\(int, int, int, int\)

```csharp
public Color(int r, int g, int b, int a)
```

#### Parameters

`r` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`g` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`b` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`a` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="HarpEngine_Graphics_Color__ctor_System_Int32_System_Int32_System_Int32_"></a> Color\(int, int, int\)

```csharp
public Color(int r, int g, int b)
```

#### Parameters

`r` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`g` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`b` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="HarpEngine_Graphics_Color__ctor_System_Single_System_Single_System_Single_System_Single_"></a> Color\(float, float, float, float\)

```csharp
public Color(float r, float g, float b, float a)
```

#### Parameters

`r` [float](https://learn.microsoft.com/dotnet/api/system.single)

`g` [float](https://learn.microsoft.com/dotnet/api/system.single)

`b` [float](https://learn.microsoft.com/dotnet/api/system.single)

`a` [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="HarpEngine_Graphics_Color__ctor_System_Single_System_Single_System_Single_"></a> Color\(float, float, float\)

```csharp
public Color(float r, float g, float b)
```

#### Parameters

`r` [float](https://learn.microsoft.com/dotnet/api/system.single)

`g` [float](https://learn.microsoft.com/dotnet/api/system.single)

`b` [float](https://learn.microsoft.com/dotnet/api/system.single)

## Fields

### <a id="HarpEngine_Graphics_Color_A"></a> A

```csharp
public byte A
```

#### Field Value

 [byte](https://learn.microsoft.com/dotnet/api/system.byte)

### <a id="HarpEngine_Graphics_Color_B"></a> B

```csharp
public byte B
```

#### Field Value

 [byte](https://learn.microsoft.com/dotnet/api/system.byte)

### <a id="HarpEngine_Graphics_Color_G"></a> G

```csharp
public byte G
```

#### Field Value

 [byte](https://learn.microsoft.com/dotnet/api/system.byte)

### <a id="HarpEngine_Graphics_Color_R"></a> R

```csharp
public byte R
```

#### Field Value

 [byte](https://learn.microsoft.com/dotnet/api/system.byte)

## Methods

### <a id="HarpEngine_Graphics_Color_DropAlpha"></a> DropAlpha\(\)

```csharp
public Color DropAlpha()
```

#### Returns

 [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Color_Lerp_HarpEngine_Graphics_Color_HarpEngine_Graphics_Color_System_Single_"></a> Lerp\(Color, Color, float\)

```csharp
public static Color Lerp(Color from, Color to, float amount)
```

#### Parameters

`from` [Color](HarpEngine.Graphics.Color.md)

`to` [Color](HarpEngine.Graphics.Color.md)

`amount` [float](https://learn.microsoft.com/dotnet/api/system.single)

#### Returns

 [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Graphics_Color_ToString"></a> ToString\(\)

Returns the fully qualified type name of this instance.

```csharp
public override string ToString()
```

#### Returns

 [string](https://learn.microsoft.com/dotnet/api/system.string)

The fully qualified type name.

