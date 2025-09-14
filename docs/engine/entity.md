# Entity
Entities are where all of your core game logic will exist. It is an object that exists physically in your game. Entities can be a player, or a wall, or a magic potion. The implementation is pretty simple, and leaves all of the fun work up to you:

```csharp
public class CustomEntity : Entity
{
	public CustomEntity(Scene scene) : base(scene)
	{
		// Initialize
	}

	public override void Update(float frameTime)
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

It's important to note that the entities [scene](scene.md) can be accessed from here! For instance:

```csharp
public override void Update(float frameTime)
{
	if (scene.Time > 5) Explode();
}
```

If your entity is host to a custom scene with useful methods, it might be a good idea to save that reference:

```csharp
private GameScene gameScene;
private int health;

public CustomEntity(GameScene gameScene) : base(gameScene)
{
	this.gameScene = gameScene;
}

public override void Update(float frameTime)
{
	if (health <= 0) gameScene.GameOver();
}
```

Finally, `Entity` has several very useful public properties:
- Entity.IsUpdating
- Entity.IsRendering
- Entity.UpdateLayer
- Entity.DrawLayer