namespace HarpEngine.Utilities;

public class Transform2D
{
	public Vector2 WorldPosition
	{
		get
		{
			if (Parent is null) return LocalPosition;
			else return Vector2.Transform(LocalPosition, Parent.Matrix);
		}

		set
		{
			if (Parent is null) LocalPosition = value;
			else LocalPosition = Vector2.Transform(value, Parent.MatrixInverse);
		}
	}
	public Vector2 LocalPosition;

	public float WorldRotation
	{
		get
		{
			if (Parent is null) return LocalRotation;
			else return Parent.WorldRotation + LocalRotation;
		}

		set
		{
			if (Parent is null) LocalRotation = value;
			else LocalRotation = value - Parent.WorldRotation;
		}
	}

	public float LocalRotation;

	public Transform2D Parent;

	public Matrix3x2 Matrix
	{
		get
		{
			Matrix3x2 translationMatrix = Matrix3x2.CreateTranslation(WorldPosition);
			Matrix3x2 rotationMatrix = Matrix3x2.CreateRotation(float.DegreesToRadians(WorldRotation));
			Matrix3x2 localToWorld = rotationMatrix * translationMatrix;
			if (Parent is null) return localToWorld;
			else return Parent.Matrix * localToWorld;
		}
	}
	public Matrix3x2 MatrixInverse
	{
		get
		{
			Matrix3x2.Invert(Matrix, out Matrix3x2 WorldToLocalMatrix);
			return WorldToLocalMatrix;
		}
	}
}
