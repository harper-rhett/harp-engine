namespace HarpEngine.Graphics;

[StructLayout(LayoutKind.Sequential)]
internal struct Camera2D
{
	public Vector2 Offset;
	public Vector2 Target;
	public float Rotation;
	public float Zoom;

	public Camera2D(Vector2 offset, Vector2 target, float rotation, float zoom)
	{
		Offset = offset;
		Target = target;
		Rotation = rotation;
		Zoom = zoom;
	}

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void BeginMode2D(Camera2D camera2D);
	public static void BeginRendering(Camera2D camera2D) => BeginMode2D(camera2D);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void EndMode2D();
	public static void EndRendering() => EndMode2D();
}