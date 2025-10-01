namespace HarpEngine.Shapes;

public class LineShape : Entity
{
	public Vector2 StartPosition;
	public Vector2 EndPosition;
	public float Thickness;
	public Color Color;

	public LineShape(Scene scene, float thickness, Color color) : base(scene)
	{
		Thickness = thickness;
		Color = color;
	}

	public override void Draw()
	{
		Primitives.DrawLine(StartPosition, EndPosition, Thickness, Color);
	}
}
