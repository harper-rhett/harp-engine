# Graphics
> `using HarpEngine.Graphics;`

The graphics namespace contains everything needed to draw to the screen. A circle, drawn at (0, 0), with a radius of 8, is drawn like so:

```csharp
Primitives.DrawCircle(0, 0, 8, Colors.Blue)
```

or, like so:

```csharp
Primitives.DrawCircle(Vector2.Zero, 8, Colors.Blue);
```

Many draw methods have overloads that allow for additional options. Some are more complicated than others, and can be found in different places. Indeed, basic shapes are found in the static `Primitives` class, but splines have their own class:

```csharp
// splines have a slightly different syntax in the current version
Spline.DrawLinear(splinePositions, splineThickness, splineColor);
```

Text, for instance, also has its own class as well. Drawing horizontally centered text might look like this:

```csharp
string text = "Eat my shorts!";
int textWidth = Text.MeasureWidth(text, fontSize);
int textX = Engine.HalfGameWidth - textWidth / 2;
Text.Draw(text, textX, textY, fontSize, Colors.White);
```

But, of course, you will need to be able to draw textures as well. That process looks a little bit like this:

```csharp
Texture alligatorTexture = Texture.Load("alligator.png");
alligatorTexture.Draw(x, y, Colors.White);
```

And then there is such a thing as a `RenderTexture` as well, which can be drawn to and has a texture of its own:

```csharp
// Recommended to do this in update
RenderTexture.BeginDrawing(myRenderTexture);
Primitives.DrawPolygon(position, sides, radius, rotation, color);
RenderTexture.EndDrawing();

// And this of course in draw
myRenderTexture.Texture.Draw(x, y, Colors.White);
```

And finally, don't forget to clean up your textures! Remember, Raylib is written in C, so these structures have no garbage collection. You must call `texture.Dispose()` or else the memory will not be release until the game exits.

Check out the source code to find out more information about this namespace. Other features include:
- Shaders
- Images
- Blend modes