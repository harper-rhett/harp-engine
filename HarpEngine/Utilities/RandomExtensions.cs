namespace HarpEngine.Utilities;

public static class RandomExtensions
{
	public static float NextFloat(this Random random)
	{
		return (float)random.NextDouble();
	}

	public static float NextFloat(this Random random, float max)
	{
		return random.NextFloat() * max;
	}

	public static float NextFloat(this Random random, float min, float max)
	{
		return min + random.NextFloat() * (max - min);
	}

	public static bool NextBool(this Random random)
	{
		return random.NextDouble() > 0.5;
	}

	public static float NextRadians(this Random random)
	{
		return random.NextFloat() * MathF.Tau;
	}

	public static float NextDegrees(this Random random)
	{
		return random.NextFloat() * 360f;
	}

	public static Vector2 NextVector2(this Random random)
	{
		float radians = random.NextRadians();
		float x = MathF.Cos(radians);
		float y = MathF.Sin(radians);
		Vector2 randomVector = new Vector2(x, y);
		return Vector2.Normalize(randomVector);
	}
}
