# Scene
A scene is an entity management system. Entities are added to the scene, and then the scene manages their update and draw loops.

The [Game](game.md) class should be used to manage scenes. If you are prototyping a game loop, you could just have one scene and then add your entities like so:

```csharp
internal class MyGame : Game
{
	Scene scene = new();

	public MyGame()
	{
		new CustomEntity(scene); // inherits from entity and is added to scene
	}

	public override void Update(float frameTime)
	{
		scene.Update(frameTime);
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

Then those scenes are managed in [Game](game.md) but all of the game logic exists within the scene nested in entities.

The usefulness of a scene is perhaps escaping you, but we have only just begun.

P.S. Scenes also contain a field for a camera, if your game uses one. More on this in [Camera](camera.md).

## Timing
Scenes have their own timing system that starts when a scene is created and is measured in seconds. What's so great about this is that the system is pausable and distortable. The calls are as simple as this:

```csharp
Console.WriteLine(scene.Time); // in seconds
scene.IsPaused = true;
scene.TimeModifier = 2;
```

This means if you need a game scene and a pause menu scene, you can run both at once and pause the game scene. And, unpausing will pick up right where you left off. No time passes for a scene when it is paused. And, of course all entities are paused and live in this system, but they also all have a reference to scene. So, they can use that reference for any time related needs. Check out the [timers](../utilities/timers.md) for an example of this.

# Entities
`Entities` is an actual class that each scene contains a public instance of. It's the actual collection of entities and handles update and draw order, as well as a registry for fast lookups.

More on update and draw order in [Entity](entity.md). As for the registry, it can be used like so:

```csharp
CustomEntity myEntity = scene.Entities.GetEntity<CustomEntity>(); // returns the last CustomEntity added to the scene
CustomEntity[] myEntities = scene.Entities.GetEntities<CustomEntity>(); // returns every CustomEntity in the scene
```