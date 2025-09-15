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
Spline.DrawLinear(splinePositions, int positionCount, float thickness, Color color)
```