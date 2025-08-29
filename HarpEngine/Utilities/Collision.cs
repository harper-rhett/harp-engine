namespace HarpEngine.Utilities;

public static class Collision
{
	public static bool PointInCircle(Vector2 pointPosition, Vector2 circlePosition, float radiusSquared)
	{
		float distanceSquared = Vector2.DistanceSquared(pointPosition, circlePosition);
		return distanceSquared < radiusSquared;
	}

	public static bool CircleOnCircle(Vector2 positionA, float radiusSquaredA, Vector2 positionB, float radiusSquaredB)
	{
		float distanceSquared = Vector2.DistanceSquared(positionA, positionB);
		return distanceSquared < radiusSquaredA + radiusSquaredB;
	}

	public static bool CircleInCirlce(Vector2 positionA, float radiusSquaredA, Vector2 positionB, float radiusSquaredB)
	{
		float distanceSquared = Vector2.DistanceSquared(positionA, positionB);
		return distanceSquared < radiusSquaredB - radiusSquaredA;
	}
}
