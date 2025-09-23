# Animation
> `using HarpEngine.Animation`

Currently, the animation namespace is solely the home to the `Easer` and `Curves` classes, which fit together like puzzle pieces. They were created to help with simple programatic animations. Check it out:

```csharp
Easer starEaser = new Easer(scene, easeSeconds);
starEaser.Curve = Curves.SmoothStep;
starEaser.Easing += EaseShootingStar;
starEaser.Start();

void EaseShootingStar(Easer easer)
{
	star.Position = easer.EaseVector2(startPosition, endPosition);
	star.Rotation = easer.EaseFloat(startRotation, endRotation);
	star.Color = easer.EaseColor(startColor, endColor);
}
```

This moves a star, rotates it, and interpolates its color. Then the easer kills itself when it is finished (or not, if you set `RemoveOnFinished` to `false`). You can also tell the easer to repeat itself with the `Rewind` property. There are a large range of curves to choose from, and because they are delegates, you can even design your own. Here's an example of one of the simplest curves from the `Curves` class:

```csharp
public static float Cubic(float x)
{
	return x * x * x;
}
```