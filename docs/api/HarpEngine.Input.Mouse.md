# <a id="HarpEngine_Input_Mouse"></a> Class Mouse

Namespace: [HarpEngine.Input](HarpEngine.Input.md)  
Assembly: HarpEngine.dll  

```csharp
public static class Mouse
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Mouse](HarpEngine.Input.Mouse.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Properties

### <a id="HarpEngine_Input_Mouse_Delta"></a> Delta

```csharp
public static Vector2 Delta { get; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="HarpEngine_Input_Mouse_GameX"></a> GameX

```csharp
public static int GameX { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="HarpEngine_Input_Mouse_GameY"></a> GameY

```csharp
public static int GameY { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="HarpEngine_Input_Mouse_WheelDelta"></a> WheelDelta

```csharp
public static float WheelDelta { get; }
```

#### Property Value

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="HarpEngine_Input_Mouse_WindowPosition"></a> WindowPosition

```csharp
public static Vector2 WindowPosition { get; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="HarpEngine_Input_Mouse_WindowX"></a> WindowX

```csharp
public static int WindowX { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="HarpEngine_Input_Mouse_WindowY"></a> WindowY

```csharp
public static int WindowY { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="HarpEngine_Input_Mouse_IsButtonDown_HarpEngine_Input_MouseButton_"></a> IsButtonDown\(MouseButton\)

```csharp
public static bool IsButtonDown(MouseButton mouseButton)
```

#### Parameters

`mouseButton` [MouseButton](HarpEngine.Input.MouseButton.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="HarpEngine_Input_Mouse_IsButtonPressed_HarpEngine_Input_MouseButton_"></a> IsButtonPressed\(MouseButton\)

```csharp
public static bool IsButtonPressed(MouseButton mouseButton)
```

#### Parameters

`mouseButton` [MouseButton](HarpEngine.Input.MouseButton.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="HarpEngine_Input_Mouse_IsButtonReleased_HarpEngine_Input_MouseButton_"></a> IsButtonReleased\(MouseButton\)

```csharp
public static bool IsButtonReleased(MouseButton mouseButton)
```

#### Parameters

`mouseButton` [MouseButton](HarpEngine.Input.MouseButton.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="HarpEngine_Input_Mouse_SetCursor_HarpEngine_Input_MouseCursor_"></a> SetCursor\(MouseCursor\)

```csharp
public static void SetCursor(MouseCursor mouseCursor)
```

#### Parameters

`mouseCursor` [MouseCursor](HarpEngine.Input.MouseCursor.md)

