# <a id="HarpEngine_Graphics_RenderTexture"></a> Struct RenderTexture

Namespace: [HarpEngine.Graphics](HarpEngine.Graphics.md)  
Assembly: HarpEngine.dll  

```csharp
public struct RenderTexture : IDisposable
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

### <a id="HarpEngine_Graphics_RenderTexture_Depth"></a> Depth

```csharp
public Texture Depth
```

#### Field Value

 [Texture](HarpEngine.Graphics.Texture.md)

### <a id="HarpEngine_Graphics_RenderTexture_Id"></a> Id

```csharp
public uint Id
```

#### Field Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="HarpEngine_Graphics_RenderTexture_Texture"></a> Texture

```csharp
public Texture Texture
```

#### Field Value

 [Texture](HarpEngine.Graphics.Texture.md)

## Properties

### <a id="HarpEngine_Graphics_RenderTexture_IsValid"></a> IsValid

```csharp
public bool IsValid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="HarpEngine_Graphics_RenderTexture_BeginDrawing_HarpEngine_Graphics_RenderTexture_"></a> BeginDrawing\(RenderTexture\)

```csharp
public static void BeginDrawing(RenderTexture renderTexture2D)
```

#### Parameters

`renderTexture2D` [RenderTexture](HarpEngine.Graphics.RenderTexture.md)

### <a id="HarpEngine_Graphics_RenderTexture_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="HarpEngine_Graphics_RenderTexture_EndDrawing"></a> EndDrawing\(\)

```csharp
public static void EndDrawing()
```

### <a id="HarpEngine_Graphics_RenderTexture_Load_System_Int32_System_Int32_"></a> Load\(int, int\)

```csharp
public static RenderTexture Load(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [RenderTexture](HarpEngine.Graphics.RenderTexture.md)

