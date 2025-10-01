namespace HarpEngine.Shapes;

public class PolygonShape : Entity
{
	// General
	public Transform2D Transform = new();
	public int SideCount;
	public float Radius;
	public Color Color;

	public PolygonShape(Scene scene, float radius, int sideCount, Color color) : base(scene)
	{
		Radius = radius;
		SideCount = sideCount;
		Color = color;
	}

	public override void Draw()
	{
		Primitives.DrawPolygon(Transform.WorldPosition, SideCount, Radius, Transform.WorldRotation, Color);
	}
}