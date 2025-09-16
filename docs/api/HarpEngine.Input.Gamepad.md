# <a id="HarpEngine_Input_Gamepad"></a> Class Gamepad

Namespace: [HarpEngine.Input](HarpEngine.Input.md)  
Assembly: HarpEngine.dll  

```csharp
public class Gamepad
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Gamepad](HarpEngine.Input.Gamepad.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Properties

### <a id="HarpEngine_Input_Gamepad_LastButtonPressed"></a> LastButtonPressed

```csharp
public GamepadButton LastButtonPressed { get; }
```

#### Property Value

 [GamepadButton](HarpEngine.Input.GamepadButton.md)

### <a id="HarpEngine_Input_Gamepad_Name"></a> Name

```csharp
public string Name { get; }
```

#### Property Value

 [string](https://learn.microsoft.com/dotnet/api/system.string)

## Methods

### <a id="HarpEngine_Input_Gamepad_GetAxis_HarpEngine_Input_GamepadAxis_"></a> GetAxis\(GamepadAxis\)

```csharp
public float GetAxis(GamepadAxis axis)
```

#### Parameters

`axis` [GamepadAxis](HarpEngine.Input.GamepadAxis.md)

#### Returns

 [float](https://learn.microsoft.com/dotnet/api/system.single)

### <a id="HarpEngine_Input_Gamepad_GetGamepad_System_Int32_"></a> GetGamepad\(int\)

```csharp
public static Gamepad GetGamepad(int index)
```

#### Parameters

`index` [int](https://learn.microsoft.com/dotnet/api/system.int32)

#### Returns

 [Gamepad](HarpEngine.Input.Gamepad.md)

### <a id="HarpEngine_Input_Gamepad_IsButtonDown_HarpEngine_Input_GamepadButton_"></a> IsButtonDown\(GamepadButton\)

```csharp
public bool IsButtonDown(GamepadButton button)
```

#### Parameters

`button` [GamepadButton](HarpEngine.Input.GamepadButton.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="HarpEngine_Input_Gamepad_IsButtonPressed_HarpEngine_Input_GamepadButton_"></a> IsButtonPressed\(GamepadButton\)

```csharp
public bool IsButtonPressed(GamepadButton button)
```

#### Parameters

`button` [GamepadButton](HarpEngine.Input.GamepadButton.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="HarpEngine_Input_Gamepad_IsButtonReleased_HarpEngine_Input_GamepadButton_"></a> IsButtonReleased\(GamepadButton\)

```csharp
public bool IsButtonReleased(GamepadButton button)
```

#### Parameters

`button` [GamepadButton](HarpEngine.Input.GamepadButton.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="HarpEngine_Input_Gamepad_Vibrate_System_Single_System_Single_System_Single_"></a> Vibrate\(float, float, float\)

```csharp
public void Vibrate(float leftMotor, float rightMotor, float duration)
```

#### Parameters

`leftMotor` [float](https://learn.microsoft.com/dotnet/api/system.single)

`rightMotor` [float](https://learn.microsoft.com/dotnet/api/system.single)

`duration` [float](https://learn.microsoft.com/dotnet/api/system.single)

