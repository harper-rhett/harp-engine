# Graphics
> `using HarpEngine.Graphics;`

The graphics namespace contains everything needed to draw to the screen. A circle, drawn at (0, 0), with a radius of 8, is drawn like so:

```csharp
Primitives.DrawCircle(0, 0, 8, Colors.Blue)
```

or as the following:

```csharp
Primitives.DrawCircle(Vector2.Zero, 8, Colors.Blue);
```

Many draw methods have overloads that allow for additional options. Some are more complicated than others, and can be found in different places. Basic shapes are found in the static `Primitives` class, but splines have their own class:

```csharp
// splines have a slightly different syntax in the current version
Spline.DrawLinear(splinePositions, splineThickness, splineColor);
```

Text has its own class as well. Drawing horizontally centered text might look like this:

```csharp
string text = "Eat my shorts!";
int textWidth = Text.MeasureWidth(text, fontSize);
int textX = Engine.HalfGameWidth - textWidth / 2;
Text.Draw(text, textX, textY, fontSize, Colors.White);
```

But, of course, you will need to be able to draw textures as well. That process is as follows:

```csharp
Texture alligatorTexture = Texture.Load("alligator.png");
alligatorTexture.Draw(x, y, Colors.White);
```

It is recommended textures be loaded at the beginning of a scene or at the launch of a game. Loading textures at runtime may slow down performance.

There is such a thing as a `RenderTexture` as well, which can be drawn to and has a texture of its own:

```csharp
// Recommended to do this in update
RenderTexture.BeginDrawing(myRenderTexture);
Primitives.DrawPolygon(position, sides, radius, rotation, color);
RenderTexture.EndDrawing();

// And this of course in draw
myRenderTexture.Texture.Draw(x, y, Colors.White);
```

When textures are no longer needed, they should be cleaned up with `texture.Dispose()` to release them from memory. This is not necessary if you are okay with your textures persisting in memory until the game exits.

Check out the source code to find out more information about this namespace. Other features include:

- Shaders
- Images
- Blend modes

More detailed information will be added to this page in the future about such topics.