# Randomization
> `using HarpEngine.Utilities;`

C#'s random class is lacking in many features. Especially for a game engine. So, HarpEngine adds several extensions to this class. For example, a random normalized unit `Vector2`:

```csharp
Random random = new();
Vector2 launchDirection = random.NextVector2();
```

Or random degrees from 0 to 360, which is almost silly but saves the developer just a little time:

```csharp
random.NextDegrees();
```