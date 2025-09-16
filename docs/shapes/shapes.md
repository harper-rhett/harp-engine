# Shapes
> `using HarpEngine.Shapes;`

Primitive shapes can be drawn from the `Primitives` namespace. This is different, but similar. Shapes are pre-built entities useful for prototyping that draw themselves. For instance:

```csharp
Polygon myPolygon = new(scene, radius, sideCount, color);
myPolygon.Position = customPosition;
```

These entities can also be inherited from for more control. As of version 0.1, only `Circle` and `Polygon` exist. There will be more in future versions.