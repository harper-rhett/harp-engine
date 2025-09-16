# <a id="HarpEngine_Engine"></a> Class Engine

Namespace: [HarpEngine](HarpEngine.md)  
Assembly: HarpEngine.dll  

```csharp
public static class Engine
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Engine](HarpEngine.Engine.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Properties

### <a id="HarpEngine_Engine_GameHeight"></a> GameHeight

```csharp
public static int GameHeight { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="HarpEngine_Engine_GameWidth"></a> GameWidth

```csharp
public static int GameWidth { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="HarpEngine_Engine_HalfGameHeight"></a> HalfGameHeight

```csharp
public static int HalfGameHeight { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="HarpEngine_Engine_HalfGameWidth"></a> HalfGameWidth

```csharp
public static int HalfGameWidth { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="HarpEngine_Engine_Initialize_HarpEngine_EngineSettings_"></a> Initialize\(EngineSettings\)

```csharp
public static void Initialize(EngineSettings engineSettings)
```

#### Parameters

`engineSettings` [EngineSettings](HarpEngine.EngineSettings.md)

### <a id="HarpEngine_Engine_SetTargetFPS_System_Int32_"></a> SetTargetFPS\(int\)

```csharp
public static extern void SetTargetFPS(int fps)
```

#### Parameters

`fps` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="HarpEngine_Engine_Start_HarpEngine_Game_"></a> Start\(Game\)

```csharp
public static void Start(Game game)
```

#### Parameters

`game` [Game](HarpEngine.Game.md)

### <a id="HarpEngine_Engine_TakeScreenshot_System_String_"></a> TakeScreenshot\(string\)

```csharp
public static extern void TakeScreenshot(string fileName)
```

#### Parameters

`fileName` [string](https://learn.microsoft.com/dotnet/api/system.string)

