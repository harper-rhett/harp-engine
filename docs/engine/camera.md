# Camera
`Camera2D` works well, but is subject to change, so the documentation will be limited until the implementation is more final. A scene's camera is automatically set when you create a new camera (this will change):

```csharp
new Camera2D(scene); // maybe don't do this
```

Though, you can also set it yourself:

```csharp
scene.Camera = new Camera2D(scene); // do this instead
```

Which, I recommend, because I am about to remove the auto set. Makes a little more since to explicitly set the scene's camera.

The camera has a [transform](../utilities/transforms.md) which you can access to move and rotate it. It also has easing methods which are useful for animating transitions.

That is all for now.