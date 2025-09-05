namespace HarpEngine.Shapes;

public class Polygon : Entity
{
	// General
	public Vector2 Position;
	public int SideCount;
	public float Radius;
	public Color Color;
	public float Rotation;

	public Polygon(Scene scene, float radius, int sideCount, Color color) : base(scene)
	{
		this.Radius = radius;
		this.SideCount = sideCount;
		this.Color = color;
	}

	public override void Draw()
	{
		Primitives.DrawPolygon(Position, SideCount, Radius, Rotation, Color);
	}
}