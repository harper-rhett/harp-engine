# Randomization
> `using HarpEngine.Utilities;`

C#'s random class is lacking in many features. Especially for a game engine. So, HarpEngine adds several extensions to this class. For example, to generate a random unit `Vector2`:

```csharp
Random random = new();
Vector2 launchDirection = random.NextVector2();
```

Or to generate random degrees from 0 to 360, which is almost silly but still saves enough boilerplate to be worth it:

```csharp
float degrees = random.NextDegrees();
```