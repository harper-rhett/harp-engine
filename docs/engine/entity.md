# Entity
An entity is an object that exists physically in your game. Entities can be a player, or a wall, or a magic potion. The implementation is pretty simple, and leaves all of the fun work up to you:

```csharp
public class CustomEntity : Entity
{
	public CustomEntity(Scene scene) : base(scene)
	{
		// Initialize
	}

	public override void Update()
	{
		// Movement, animation, input, etc.
	}

	public override void Draw()
	{
		// Shapes, textures, text, etc.
	}

	public override void OnRemove()
	{
		// clean up resources here, like other entities created by this one
	}
}
```

It's important to note that the entities [scene](scene.md) can be accessed from inside the class. For instance:

```csharp
public override void Update()
{
	if (scene.Time > 5) Explode();
}
```

If your entity belongs to a custom scene with useful methods, it might be a good idea to save the scene's reference for later:

```csharp
private GameScene gameScene;
private int health;

public CustomEntity(GameScene gameScene) : base(gameScene)
{
	this.gameScene = gameScene;
}

public override void Update()
{
	if (health <= 0) gameScene.GameOver();
}
```

Finally, `Entity` has several very useful public properties:
- `Entity.IsUpdating`: Pause the update loop.
- `Entity.IsRendering`: Pause the draw loop.
- `Entity.UpdateLayer`: Change the update layer.
- `Entity.DrawLayer`: Change the draw layer.