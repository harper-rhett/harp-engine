# Game
The game class is a starting point for your game code to be called by [Engine](engine.md), and nothing else:

```csharp
internal class MyGame : Game
{
	public MyGame()
	{

	}

	public override void Update()
	{
		
	}

	public override void Draw()
	{
		
	}
}
```

As a matter of fact, it's so ridiculously simple, the source code can be pasted right here:

```csharp
public abstract class Game
{
	public abstract void Update();
	public abstract void Draw();
}
```

It is recommended that the `Game` class be treated as a scene management system, as opposed to hosting any actual game logic. Most of your game logic will be written into entities. More on this in the [scene](scene.md) and [entity](entity.md) docs.