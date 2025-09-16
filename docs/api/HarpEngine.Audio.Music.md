# <a id="HarpEngine_Audio_Music"></a> Struct Music

Namespace: [HarpEngine.Audio](HarpEngine.Audio.md)  
Assembly: HarpEngine.dll  

```csharp
public struct Music : IDisposable
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

### <a id="HarpEngine_Audio_Music_CtxData"></a> CtxData

```csharp
public void* CtxData
```

#### Field Value

 [void](https://learn.microsoft.com/dotnet/api/system.void)\*

### <a id="HarpEngine_Audio_Music_CtxType"></a> CtxType

```csharp
public int CtxType
```

#### Field Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="HarpEngine_Audio_Music_FrameCount"></a> FrameCount

```csharp
public uint FrameCount
```

#### Field Value

 [uint](https://learn.microsoft.com/dotnet/api/system.uint32)

### <a id="HarpEngine_Audio_Music_Stream"></a> Stream

```csharp
public AudioStream Stream
```

#### Field Value

 [AudioStream](HarpEngine.Audio.AudioStream.md)

## Properties

### <a id="HarpEngine_Audio_Music_Duration"></a> Duration

```csharp
public float Duration { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="HarpEngine_Audio_Music_IsPlaying"></a> IsPlaying

```csharp
public bool IsPlaying { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="HarpEngine_Audio_Music_IsValid"></a> IsValid

```csharp
public bool IsValid { get; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="HarpEngine_Audio_Music_Looping"></a> Looping

```csharp
public bool Looping { get; set; }
```

#### Property Value

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="HarpEngine_Audio_Music_Pitch"></a> Pitch

```csharp
public float Pitch { set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="HarpEngine_Audio_Music_Position"></a> Position

```csharp
public float Position { set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="HarpEngine_Audio_Music_StereoPan"></a> StereoPan

```csharp
public float StereoPan { set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="HarpEngine_Audio_Music_TimePlayed"></a> TimePlayed

```csharp
public float TimePlayed { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="HarpEngine_Audio_Music_Volume"></a> Volume

```csharp
public float Volume { set; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

## Methods

### <a id="HarpEngine_Audio_Music_Dispose"></a> Dispose\(\)

Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.

```csharp
public void Dispose()
```

### <a id="HarpEngine_Audio_Music_Load_System_String_"></a> Load\(string\)

```csharp
public static Music Load(string filePath)
```

#### Parameters

`filePath` [string](https://learn.microsoft.com/dotnet/api/system.string)

#### Returns

 [Music](HarpEngine.Audio.Music.md)

### <a id="HarpEngine_Audio_Music_Pause"></a> Pause\(\)

```csharp
public void Pause()
```

### <a id="HarpEngine_Audio_Music_Play"></a> Play\(\)

```csharp
public void Play()
```

### <a id="HarpEngine_Audio_Music_Resume"></a> Resume\(\)

```csharp
public void Resume()
```

### <a id="HarpEngine_Audio_Music_Stop"></a> Stop\(\)

```csharp
public void Stop()
```

### <a id="HarpEngine_Audio_Music_Update"></a> Update\(\)

```csharp
public void Update()
```

