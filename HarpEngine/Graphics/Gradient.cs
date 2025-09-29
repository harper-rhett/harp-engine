using System.Runtime.CompilerServices;

namespace HarpEngine.Graphics;

public class Gradient
{
	private List<ColorPoint> colorPoints = new();

	public Gradient(params Color[] colors)
	{
		float spacing = 1f / (colors.Length - 1);
		for (int colorIndex = 0; colorIndex < colors.Length; colorIndex++)
		{
			Color color = colors[colorIndex];
			float position = colorIndex * spacing;
			ColorPoint colorPoint = new(color, position);
			colorPoints.Add(colorPoint);
		}
	}

	public void AddColor(Color color, float position)
	{
		ColorPoint newColorPoint = new()
		{
			Color = color,
			Position = position
		};
		int insertIndex = colorPoints.BinarySearch(newColorPoint);
		if (insertIndex < 0) insertIndex = ~insertIndex;
		colorPoints.Insert(insertIndex, newColorPoint);
	}

	public Color Sample(float position)
	{
		// If no color, return white
		if (colorPoints.Count == 0) return Colors.White;

		// If only one color, return that color
		ColorPoint previousColorPoint = colorPoints[0];
		if (colorPoints.Count == 1) return previousColorPoint.Color;

		// If multiple colors, search for the right range
		for (int index = 0; index < colorPoints.Count; index++)
		{
			ColorPoint nextColorPoint = colorPoints[index];

			if (position <= nextColorPoint.Position)
			{
				if (index == 0) return previousColorPoint.Color;
				else return SamplePoints(previousColorPoint, nextColorPoint, position);
			}
			else
			{
				ColorPoint lastColorPoint = colorPoints.Last();
				if (position > lastColorPoint.Position) return lastColorPoint.Color;
			}

			previousColorPoint = nextColorPoint;
		}

		// If for some reason we reach this point, return white
		return Colors.White;
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

		public ColorPoint(Color color, float position)
		{
			Color = color;
			Position = position;
		}

		public int CompareTo(ColorPoint otherColorPoint)
		{
			return Position.CompareTo(otherColorPoint.Position);
		}
	}
}
