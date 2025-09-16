# <a id="HarpEngine_Input_Keyboard"></a> Class Keyboard

Namespace: [HarpEngine.Input](HarpEngine.Input.md)  
Assembly: HarpEngine.dll  

```csharp
public static class Keyboard
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Keyboard](HarpEngine.Input.Keyboard.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Methods

### <a id="HarpEngine_Input_Keyboard_GetKeyPressed"></a> GetKeyPressed\(\)

```csharp
public static extern KeyboardKey GetKeyPressed()
```

#### Returns

 [KeyboardKey](HarpEngine.Input.KeyboardKey.md)

### <a id="HarpEngine_Input_Keyboard_GetUnicodePressed"></a> GetUnicodePressed\(\)

```csharp
public static int GetUnicodePressed()
```

#### Returns

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="HarpEngine_Input_Keyboard_IsKeyDown_HarpEngine_Input_KeyboardKey_"></a> IsKeyDown\(KeyboardKey\)

```csharp
public static extern bool IsKeyDown(KeyboardKey key)
```

#### Parameters

`key` [KeyboardKey](HarpEngine.Input.KeyboardKey.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="HarpEngine_Input_Keyboard_IsKeyPressed_HarpEngine_Input_KeyboardKey_"></a> IsKeyPressed\(KeyboardKey\)

```csharp
public static extern bool IsKeyPressed(KeyboardKey key)
```

#### Parameters

`key` [KeyboardKey](HarpEngine.Input.KeyboardKey.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="HarpEngine_Input_Keyboard_IsKeyReleased_HarpEngine_Input_KeyboardKey_"></a> IsKeyReleased\(KeyboardKey\)

```csharp
public static extern bool IsKeyReleased(KeyboardKey key)
```

#### Parameters

`key` [KeyboardKey](HarpEngine.Input.KeyboardKey.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="HarpEngine_Input_Keyboard_IsKeyRepeating_HarpEngine_Input_KeyboardKey_"></a> IsKeyRepeating\(KeyboardKey\)

```csharp
public static extern bool IsKeyRepeating(KeyboardKey key)
```

#### Parameters

`key` [KeyboardKey](HarpEngine.Input.KeyboardKey.md)

#### Returns

 [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

