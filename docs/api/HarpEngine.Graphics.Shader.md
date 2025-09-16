# <a id="HarpEngine_Graphics_Shader"></a> Struct Shader

Namespace: [HarpEngine.Graphics](HarpEngine.Graphics.md)  
Assembly: HarpEngine.dll  

```csharp
public struct Shader : IDisposable
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

## Properties

### <a id="HarpEngine_Graphics_Shader_IsValid"></a> IsValid

```csharp
public bool IsValid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

## Methods

### <a id="HarpEngine_Graphics_Shader_BeginUsing_HarpEngine_Graphics_Shader_"></a> BeginUsing\(Shader\)

```csharp
public static void BeginUsing(Shader shader)
```

#### Parameters

`shader` [Shader](HarpEngine.Graphics.Shader.md)

### <a id="HarpEngine_Graphics_Shader_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="HarpEngine_Graphics_Shader_EndUsing"></a> EndUsing\(\)

```csharp
public static void EndUsing()
```

### <a id="HarpEngine_Graphics_Shader_LoadFromCode_System_String_System_String_"></a> LoadFromCode\(string, string\)

```csharp
public static Shader LoadFromCode(string vertexCode, string fragmentCode)
```

#### Parameters

`vertexCode` [string](https://learn.microsoft.com/dotnet/api/system.string)

`fragmentCode` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [Shader](HarpEngine.Graphics.Shader.md)

### <a id="HarpEngine_Graphics_Shader_LoadFromFile_System_String_System_String_"></a> LoadFromFile\(string, string\)

```csharp
public static Shader LoadFromFile(string vertexFileName, string fragmentFileName)
```

#### Parameters

`vertexFileName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`fragmentFileName` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [Shader](HarpEngine.Graphics.Shader.md)

### <a id="HarpEngine_Graphics_Shader_SetArray_System_String_System_Void__HarpEngine_Graphics_UniformDataType_System_Int32_"></a> SetArray\(string, void\*, UniformDataType, int\)

```csharp
public void SetArray(string variableName, void* value, UniformDataType dataType, int count)
```

#### Parameters

`variableName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`value` [void](https://learn.microsoft.com/dotnet/api/system.void)\*

`dataType` [UniformDataType](HarpEngine.Graphics.UniformDataType.md)

`count` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="HarpEngine_Graphics_Shader_SetMatrix_System_String_System_Numerics_Matrix4x4_"></a> SetMatrix\(string, Matrix4x4\)

```csharp
public void SetMatrix(string variableName, Matrix4x4 matrix)
```

#### Parameters

`variableName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`matrix` [Matrix4x4](https://learn.microsoft.com/dotnet/api/system.numerics.matrix4x4)

### <a id="HarpEngine_Graphics_Shader_SetTexture_System_String_HarpEngine_Graphics_Texture_"></a> SetTexture\(string, Texture\)

```csharp
public void SetTexture(string variableName, Texture texture)
```

#### Parameters

`variableName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`texture` [Texture](HarpEngine.Graphics.Texture.md)

### <a id="HarpEngine_Graphics_Shader_SetValue_System_String_System_Void__HarpEngine_Graphics_UniformDataType_"></a> SetValue\(string, void\*, UniformDataType\)

```csharp
public void SetValue(string variableName, void* value, UniformDataType dataType)
```

#### Parameters

`variableName` [string](https://learn.microsoft.com/dotnet/api/system.string)

`value` [void](https://learn.microsoft.com/dotnet/api/system.void)\*

`dataType` [UniformDataType](HarpEngine.Graphics.UniformDataType.md)

