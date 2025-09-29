namespace HarpEngine.Graphics;

public class Gradient
{
	private List<ColorPoint> colors = new();

	public Gradient(Color color, float colorPosition)
	{
		ColorPoint colorPoint = new()
		{
			Color = color,
			Position = colorPosition
		};
		colors.Add(colorPoint);
	}

	public void AddColor(Color color, float position)
	{
		ColorPoint newColorPoint = new()
		{
			Color = color,
			Position = position
		};
		int insertIndex = colors.BinarySearch(newColorPoint);
		if (insertIndex < 0) insertIndex = ~insertIndex;
		colors.Insert(insertIndex, newColorPoint);
	}

	public Color Sample(float position)
	{
		// If only one color, return that color
		ColorPoint previousColorPoint = colors[0];
		if (colors.Count == 1) return previousColorPoint.Color;

		// If multiple colors, search for the right range
		for (int index = 0; index < colors.Count; index++)
		{
			ColorPoint nextColorPoint = colors[index];

			if (position < nextColorPoint.Position)
			{
				return SamplePoints(previousColorPoint, nextColorPoint, position);
			}

			previousColorPoint = nextColorPoint;
		}
		return Colors.Clear;
	}

	private Color SamplePoints(ColorPoint firstPoint, ColorPoint secondPoint, float position)
	{
		float firstPosition = firstPoint.Position;
		float secondPosition = secondPoint.Position;
		float range = secondPosition - firstPosition;

		float offset = position - firstPosition;
		float progress = offset / range;

		return Color.Lerp(firstPoint.Color, secondPoint.Color, progress);
	}

	private struct ColorPoint : IComparable<ColorPoint>
	{
		public Color Color;
		public float Position;

		public int CompareTo(ColorPoint otherColorPoint)
		{
			return Position.CompareTo(otherColorPoint.Position);
		}
	}
}
