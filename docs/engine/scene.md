# Scene
A scene is an entity management system. Entities are added to the scene, and then the scene manages their update and draw loops.

The [game](game.md) class should be used to manage scenes. If you are prototyping a game loop, you could just have one scene and then add your entities like so:

```csharp
internal class MyGame : Game
{
	Scene scene = new();

	public MyGame()
	{
		new CustomEntity(scene); // inherits from entity and is added to scene
	}

	public override void Update()
	{
		scene.Update();
	}

	public override void Draw()
	{
		scene.Draw();
	}
}
```

But, if you are beyond prototyping, you should create custom scenes:

```csharp title="GameScene.cs"
internal class GameScene : Scene
{
	public GameScene()
	{
		new GameManager(this); // inherits from Entity
	}
}
```

Then those scenes are managed in `Game` but all of the game logic exists within the scene nested in entities.

P.S. Scenes also contain a field for a camera, if your game uses one. More on this in the [camera](camera.md) docs.

## Timing
Scenes have their own timing system that starts when a scene is created and is measured in seconds. What's so great about this is that the system is pausable and distortable. The calls are as simple as this:

```csharp
Console.WriteLine(scene.Time); // in seconds
scene.IsPaused = true;
scene.TimeModifier = 2;
```

This means if a game scene and a pause menu are required, both can be run at once and the game scene game be paused with leisure. Unpausing will pick up right where it left off. No time passes for a scene when it is paused. And, of course all entities are paused and live in this system, but they also all have a reference to scene. So, they can use that reference for any time related needs. Check out the [timers](../utilities/timers.md) for an example of this.

# Entities
`Entities` is an actual class that each scene contains a public instance of. It's the actual collection of entities and handles update and draw order, as well as a registry for fast lookups.

The registry can be used like so:

```csharp
CustomEntity myEntity = scene.Entities.GetEntity<CustomEntity>(); // returns the last CustomEntity added to the scene
CustomEntity[] myEntities = scene.Entities.GetEntities<CustomEntity>(); // returns every CustomEntity in the scene
```