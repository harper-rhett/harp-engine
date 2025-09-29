# Camera
`Camera2D` works well, but is subject to change, so the documentation will be limited until the implementation is more final. A scene's camera can be set like so:

```csharp
scene.Camera = new Camera2D(scene);
```

The camera has a [transform](../utilities/transforms.md) which you can access to move and rotate it. It also has easing methods which are useful for animating transitions.

That is all for now.