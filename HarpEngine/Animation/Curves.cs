namespace HarpEngine.Animation;

// Some of these functions are sourced from https://easings.net/
// I would recommend checking it out for more curves

public delegate float Curve(float value);

public static class Curves
{
	public static float Linear(float x) => x;

	public static float SmoothStep(float x)
	{
		return x * x * (3f - 2f * x);
	}

	public static float SuperSmoothStep(float x)
	{
		return x * x * x * (x * (6f * x - 15f) + 10f);
	}

	public static float Cubic(float x)
	{
		return x * x * x;
	}

	public static float CubicInverse(float x)
	{
		return 1f - float.Pow(1f - x, 3f);
	}

	public static float CubicUniform(float x)
	{
		return x < 0.5f ? 4f * x * x * x : 1f - float.Pow(-2f * x + 2f, 3f) / 2f;
	}

	public static float Elastic(float x)
	{
		const float baseMultiplier = 1.70158f;
		const float finalMultiplier = baseMultiplier * 1.525f;

		return x < 0.5
		  ? float.Pow(2f * x, 2f) * ((finalMultiplier + 1f) * 2f * x - finalMultiplier) / 2f
		  : (float.Pow(2f * x - 2f, 2f) * ((finalMultiplier + 1f) * (x * 2f - 2f) + finalMultiplier) + 2f) / 2f;
	}

	public static float Bounce(float x)
	{
		const float bounceMultiplier = 7.5625f;
		const float bounceDivisor = 2.75f;

		if (x < 1f / bounceDivisor)
			return bounceMultiplier * x * x;
		else if (x < 2f / bounceDivisor)
			return bounceMultiplier * (x -= 1.5f / bounceDivisor) * x + 0.75f;
		else if (x < 2.5f / bounceDivisor)
			return bounceMultiplier * (x -= 2.25f / bounceDivisor) * x + 0.9375f;
		else
			return bounceMultiplier * (x -= 2.625f / bounceDivisor) * x + 0.984375f;
	}
}