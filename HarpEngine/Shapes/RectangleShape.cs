namespace HarpEngine.Shapes;

public class RectangleShape : Entity
{
	public Transform2D Transform = new();
	public Vector2 Origin = Vector2.Zero;
	public int Width;
	public int Height;
	public Color Color;

	public RectangleShape(Scene scene, int width, int height, Color color) : base(scene)
	{
		Width = width;
		Height = height;
		Color = color;
	}

	public override void Update()
	{
		
	}

	public override void Draw()
	{
		Rectangle rectangle = new(Transform.WorldPosition, Width, Height);
		Primitives.DrawRectangle(rectangle, Origin, Transform.WorldRotation, Color);
	}
}
