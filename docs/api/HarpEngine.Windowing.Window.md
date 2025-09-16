# <a id="HarpEngine_Windowing_Window"></a> Class Window

Namespace: [HarpEngine.Windowing](HarpEngine.Windowing.md)  
Assembly: HarpEngine.dll  

```csharp
public static class Window
```

#### Inheritance

[object](https://learn.microsoft.com/dotnet/api/system.object) ← 
[Window](HarpEngine.Windowing.Window.md)

#### Inherited Members

[object.Equals\(object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\)), 
[object.Equals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.equals\#system\-object\-equals\(system\-object\-system\-object\)), 
[object.GetHashCode\(\)](https://learn.microsoft.com/dotnet/api/system.object.gethashcode), 
[object.GetType\(\)](https://learn.microsoft.com/dotnet/api/system.object.gettype), 
[object.MemberwiseClone\(\)](https://learn.microsoft.com/dotnet/api/system.object.memberwiseclone), 
[object.ReferenceEquals\(object?, object?\)](https://learn.microsoft.com/dotnet/api/system.object.referenceequals), 
[object.ToString\(\)](https://learn.microsoft.com/dotnet/api/system.object.tostring)

## Properties

### <a id="HarpEngine_Windowing_Window_Height"></a> Height

```csharp
public static int Height { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="HarpEngine_Windowing_Window_Position"></a> Position

```csharp
public static Vector2 Position { get; }
```

#### Property Value

 [Vector2](https://learn.microsoft.com/dotnet/api/system.numerics.vector2)

### <a id="HarpEngine_Windowing_Window_Width"></a> Width

```csharp
public static int Width { get; }
```

#### Property Value

 [int](https://learn.microsoft.com/dotnet/api/system.int32)

## Methods

### <a id="HarpEngine_Windowing_Window_ChangeTitle_System_String_"></a> ChangeTitle\(string\)

```csharp
public static void ChangeTitle(string title)
```

#### Parameters

`title` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="HarpEngine_Windowing_Window_Close"></a> Close\(\)

```csharp
public static void Close()
```

### <a id="HarpEngine_Windowing_Window_Focus"></a> Focus\(\)

```csharp
public static void Focus()
```

### <a id="HarpEngine_Windowing_Window_Initialize_System_Int32_System_Int32_System_String_"></a> Initialize\(int, int, string\)

```csharp
public static void Initialize(int width, int height, string title)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`title` [string](https://learn.microsoft.com/dotnet/api/system.string)

### <a id="HarpEngine_Windowing_Window_Resize_System_Int32_System_Int32_"></a> Resize\(int, int\)

```csharp
public static void Resize(int width, int height)
```

#### Parameters

`width` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`height` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="HarpEngine_Windowing_Window_SetBorderless_System_Boolean_"></a> SetBorderless\(bool\)

```csharp
public static void SetBorderless(bool isBorderless)
```

#### Parameters

`isBorderless` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="HarpEngine_Windowing_Window_SetExitKey_HarpEngine_Input_KeyboardKey_"></a> SetExitKey\(KeyboardKey\)

```csharp
public static extern void SetExitKey(KeyboardKey key)
```

#### Parameters

`key` [KeyboardKey](HarpEngine.Input.KeyboardKey.md)

### <a id="HarpEngine_Windowing_Window_SetFullscreen_System_Boolean_"></a> SetFullscreen\(bool\)

```csharp
public static void SetFullscreen(bool isFullscreen)
```

#### Parameters

`isFullscreen` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="HarpEngine_Windowing_Window_SetIcon_HarpEngine_Graphics_Image_"></a> SetIcon\(Image\)

```csharp
public static void SetIcon(Image image)
```

#### Parameters

`image` [Image](HarpEngine.Graphics.Image.md)

### <a id="HarpEngine_Windowing_Window_SetIcons_HarpEngine_Graphics_Image__System_Int32_"></a> SetIcons\(Image\*, int\)

```csharp
public static void SetIcons(Image* images, int count)
```

#### Parameters

`images` [Image](HarpEngine.Graphics.Image.md)\*

`count` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="HarpEngine_Windowing_Window_SetMSAA4x_System_Boolean_"></a> SetMSAA4x\(bool\)

```csharp
public static void SetMSAA4x(bool isEnabled)
```

#### Parameters

`isEnabled` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="HarpEngine_Windowing_Window_SetMaximized_System_Boolean_"></a> SetMaximized\(bool\)

```csharp
public static void SetMaximized(bool isMaximized)
```

#### Parameters

`isMaximized` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="HarpEngine_Windowing_Window_SetMinimized_System_Boolean_"></a> SetMinimized\(bool\)

```csharp
public static void SetMinimized(bool isMinimized)
```

#### Parameters

`isMinimized` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="HarpEngine_Windowing_Window_SetMonitor_System_Int32_"></a> SetMonitor\(int\)

```csharp
public static void SetMonitor(int monitor)
```

#### Parameters

`monitor` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="HarpEngine_Windowing_Window_SetPosition_System_Int32_System_Int32_"></a> SetPosition\(int, int\)

```csharp
public static void SetPosition(int x, int y)
```

#### Parameters

`x` [int](https://learn.microsoft.com/dotnet/api/system.int32)

`y` [int](https://learn.microsoft.com/dotnet/api/system.int32)

### <a id="HarpEngine_Windowing_Window_SetRendererClipped"></a> SetRendererClipped\(\)

```csharp
public static void SetRendererClipped()
```

### <a id="HarpEngine_Windowing_Window_SetRendererUnclipped_HarpEngine_Graphics_Color_"></a> SetRendererUnclipped\(Color\)

```csharp
public static void SetRendererUnclipped(Color borderColor)
```

#### Parameters

`borderColor` [Color](HarpEngine.Graphics.Color.md)

### <a id="HarpEngine_Windowing_Window_SetResizable_System_Boolean_"></a> SetResizable\(bool\)

```csharp
public static void SetResizable(bool isResizable)
```

#### Parameters

`isResizable` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="HarpEngine_Windowing_Window_SetUndecorated_System_Boolean_"></a> SetUndecorated\(bool\)

```csharp
public static void SetUndecorated(bool isUndecorated)
```

#### Parameters

`isUndecorated` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

### <a id="HarpEngine_Windowing_Window_SetVsync_System_Boolean_"></a> SetVsync\(bool\)

```csharp
public static void SetVsync(bool isEnabled)
```

#### Parameters

`isEnabled` [bool](https://learn.microsoft.com/dotnet/api/system.boolean)

