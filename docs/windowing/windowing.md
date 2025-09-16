# Windowing
> `using HarpEngine.Windowing;`

Use the static `Window` class to change several window properties. For instance:

```csharp
Window.SetFullscreen(true);
Window.SetVsync(true);
Window.SetMSAA4x(true);
```

And the class has other useful properties and methods as well:

```csharp
int windowWidth = Window.Width;
Window.Resize(900, 800);
Window.SetExitKey(KeyboardKey.Escape);
Window.Close();
```

# Window Rendering
When creating a game in HarpEngine, you must decide what your game's resolution will be, regardless of the window's resolution. This is so that the resolution of the game may be scaled accordingly to the window's settings. There are currently 2 options for window rendering, and there will be more in the future.

## Unclipped Renderer
Set the window renderer unclipped if you would like your game's full resolution visible at all times. This will not clip the horizontal or vertical dimension of your game and will instead add borders. This is optimal for arcade-style gameplay.

```csharp
Window.SetRendererUnclipped(borderColor);
```

## Clipped Renderer
Set the window clipped if you are okay with losing some resolution depending on the window aspect ratio. A wide window will lose game height, and a tall window will lost game width.

```csharp
Window.SetRendererClipped();
```

## Future Renderers
These two options are not enough for many game types. Allow the engine some time to develop, and more options will come along.