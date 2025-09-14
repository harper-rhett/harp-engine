# Camera
`Camera2D` works well, but is subject to change, so the documentation will be limited until the implementation is more final. A scene's camera must be set is automatically set when you create a new camera:

```csharp
new Camera2D(scene);
```

Though, you can also set it yourself:

```csharp
scene.Camera = new Camera2D(scene);
```

Which, I recommend, because I am about to remove the auto set. Makes a little more since to explicitly set the scene's camera.

The camera has a [transform](../utilities/transforms.md) which you can access to move and rotate it. It also has easing methods which are useful for animating transitions.

That is all for now.