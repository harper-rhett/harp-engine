namespace HarpEngine.Graphics;

[StructLayout(LayoutKind.Sequential)]
public unsafe partial struct Shader
{
	public uint ID;
	public int* Locations;

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern Shader LoadShader(string vertexFileName, string fragmentFileName);
	public static Shader LoadFromFile(string vertexFileName, string fragmentFileName) => LoadShader(vertexFileName, fragmentFileName);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern Shader LoadShaderFromMemory(string vertexCode, string fragmentCode);
	public static Shader LoadFromCode(string vertexCode, string fragmentCode) => LoadShaderFromMemory(vertexCode, fragmentCode);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void BeginShaderMode(Shader shader);
	public static void BeginUsing(Shader shader) => BeginShaderMode(shader);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void EndShaderMode();
	public static void EndUsing() => EndShaderMode();

	// Still missing several shader methods
}