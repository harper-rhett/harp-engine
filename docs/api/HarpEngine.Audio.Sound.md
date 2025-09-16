# <a id="HarpEngine_Audio_Sound"></a> Struct Sound

Namespace: [HarpEngine.Audio](HarpEngine.Audio.md)  
Assembly: HarpEngine.dll  

```csharp
public struct Sound : IDisposable
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

### <a id="HarpEngine_Audio_Sound_FrameCount"></a> FrameCount

```csharp
public uint FrameCount
```

#### Field Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="HarpEngine_Audio_Sound_Stream"></a> Stream

```csharp
public AudioStream Stream
```

#### Field Value

 [AudioStream](HarpEngine.Audio.AudioStream.md)

## Properties

### <a id="HarpEngine_Audio_Sound_IsPlaying"></a> IsPlaying

```csharp
public bool IsPlaying { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="HarpEngine_Audio_Sound_IsValid"></a> IsValid

```csharp
public bool IsValid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="HarpEngine_Audio_Sound_Pitch"></a> Pitch

```csharp
public float Pitch { set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="HarpEngine_Audio_Sound_StereoPan"></a> StereoPan

```csharp
public float StereoPan { set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="HarpEngine_Audio_Sound_Volume"></a> Volume

```csharp
public float Volume { set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="HarpEngine_Audio_Sound_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="HarpEngine_Audio_Sound_Load_System_String_"></a> Load\(string\)

```csharp
public static Sound Load(string filePath)
```

#### Parameters

`filePath` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [Sound](HarpEngine.Audio.Sound.md)

### <a id="HarpEngine_Audio_Sound_Pause"></a> Pause\(\)

```csharp
public void Pause()
```

### <a id="HarpEngine_Audio_Sound_Play"></a> Play\(\)

```csharp
public void Play()
```

### <a id="HarpEngine_Audio_Sound_Resume"></a> Resume\(\)

```csharp
public void Resume()
```

### <a id="HarpEngine_Audio_Sound_Stop"></a> Stop\(\)

```csharp
public void Stop()
```

