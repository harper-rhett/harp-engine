> `using HarpEngine.Input;`

# Input
Input is as simple as any game developer could hope for! Check out a keyboard pressed check:

```csharp
if (Keyboard.IsKeyPressed(KeyboardKey.Space)) Jump();
```

Ah... so simple! Mouse input is roughly the same, though there are many varieties of mouse positions:

```csharp
int mouseWindowX = Mouse.WindowX; // mouse x relative to the window
int mouseGameX = Mouse.GameX; // mouse x relative to the game viewport
int mouseWorldX = myCamera2D.MouseWorldX; // mouse x relative to the world
```

And gamepads are actual objects:

```csharp
Gamepad gamepadOne = Gamepad.GetGamepad(0);
bool jumpPressed = gamepadOne.IsButtonPressed(GamepadButton.RightFaceDown); // A button on Xbox, X on Playstation
float forwardAxis = gamepadOne.GetAxis(GamepadAxis.LeftStickY);
```