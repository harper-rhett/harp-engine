namespace HarpEngine.Shapes;

public class Circle : Entity
{
	public Transform2D Transform = new();
	public float Radius;
	public Color Color;

	public Circle(Scene scene, float radius, Color color) : base(scene)
	{
		Radius = radius;
		Color = color;
	}

	public override void Draw()
	{
		Primitives.DrawCircle(Transform.WorldPosition, Radius, Color);
	}
}
