# <a id="HarpEngine_Audio_AudioStream"></a> Struct AudioStream

Namespace: [HarpEngine.Audio](HarpEngine.Audio.md)  
Assembly: HarpEngine.dll  

```csharp
public struct AudioStream : IDisposable
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

### <a id="HarpEngine_Audio_AudioStream_Buffer"></a> Buffer

```csharp
public nint Buffer
```

#### Field Value

 [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

### <a id="HarpEngine_Audio_AudioStream_Channels"></a> Channels

```csharp
public uint Channels
```

#### Field Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="HarpEngine_Audio_AudioStream_Processor"></a> Processor

```csharp
public nint Processor
```

#### Field Value

 [nint](https://learn.microsoft.com/dotnet/api/system.intptr)

### <a id="HarpEngine_Audio_AudioStream_SampleRate"></a> SampleRate

```csharp
public uint SampleRate
```

#### Field Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="HarpEngine_Audio_AudioStream_SampleSize"></a> SampleSize

```csharp
public uint SampleSize
```

#### Field Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

## Properties

### <a id="HarpEngine_Audio_AudioStream_IsPlaying"></a> IsPlaying

```csharp
public bool IsPlaying { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="HarpEngine_Audio_AudioStream_IsProcessed"></a> IsProcessed

```csharp
public bool IsProcessed { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="HarpEngine_Audio_AudioStream_IsValid"></a> IsValid

```csharp
public bool IsValid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="HarpEngine_Audio_AudioStream_Pitch"></a> Pitch

```csharp
public float Pitch { set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="HarpEngine_Audio_AudioStream_StereoPan"></a> StereoPan

```csharp
public float StereoPan { set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="HarpEngine_Audio_AudioStream_Volume"></a> Volume

```csharp
public float Volume { set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="HarpEngine_Audio_AudioStream_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="HarpEngine_Audio_AudioStream_Pause"></a> Pause\(\)

```csharp
public void Pause()
```

### <a id="HarpEngine_Audio_AudioStream_Play"></a> Play\(\)

```csharp
public void Play()
```

### <a id="HarpEngine_Audio_AudioStream_Resume"></a> Resume\(\)

```csharp
public void Resume()
```

### <a id="HarpEngine_Audio_AudioStream_Stop"></a> Stop\(\)

```csharp
public void Stop()
```

