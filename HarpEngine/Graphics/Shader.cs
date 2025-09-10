namespace HarpEngine.Graphics;

public enum UniformDataType
{
	Float = 0,
	Vec2,
	Vec3,
	Vec4,
	Int,
	IVec2,
	IVec3,
	IVec4,
	UInt,
	UIVec2,
	UIVec3,
	UIVec4,
	Sampler2D
}

[StructLayout(LayoutKind.Sequential, Size = 16)]
public unsafe struct Shader : IDisposable
{
	private uint ID;
	private int* Locations;

	private Dictionary<string, int> variableLocations;

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void BeginShaderMode(Shader shader);
	public static void BeginUsing(Shader shader) => BeginShaderMode(shader);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void EndShaderMode();
	public static void EndUsing() => EndShaderMode();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern Shader LoadShader(string vertexFileName, string fragmentFileName);
	public static Shader LoadFromFile(string vertexFileName, string fragmentFileName) => LoadShader(vertexFileName, fragmentFileName);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern Shader LoadShaderFromMemory(string vertexCode, string fragmentCode);
	public static Shader LoadFromCode(string vertexCode, string fragmentCode) => LoadShaderFromMemory(vertexCode, fragmentCode);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern bool IsShaderValid(Shader shader);
	public bool IsValid => IsShaderValid(this);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern int GetShaderLocation(Shader shader, string variableName);
	internal int GetVariableLocation(string variableName) => GetShaderLocation(this, variableName);

	internal int GetCachedVariableLocation(string variableName)
	{
		bool containsLocation = variableLocations.TryGetValue(variableName, out int variableLocation);
		if (containsLocation) return variableLocation;
		variableLocation = GetVariableLocation(variableName);
		variableLocations[variableName] = variableLocation;
		return variableLocation;
	}

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void SetShaderValue(Shader shader, int location, void* value, UniformDataType dataType);
	public void SetValue(string variableName, void* value, UniformDataType dataType)
	{
		int location = GetCachedVariableLocation(variableName);
		SetShaderValue(this, location, value, dataType);
	}

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void SetShaderValueV(Shader shader, int locIndex, void* value, UniformDataType dataType, int count);
	public void SetArray(string variableName, void* value, UniformDataType dataType, int count)
	{
		int location = GetCachedVariableLocation(variableName);
		SetShaderValueV(this, location, value, dataType, count);
	}

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void SetShaderValueMatrix(Shader shader, int location, Matrix4x4 matrix);
	public void SetMatrix(string variableName, Matrix4x4 matrix)
	{
		int location = GetCachedVariableLocation(variableName);
		SetShaderValueMatrix(this, location, matrix);
	}

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void SetShaderValueTexture(Shader shader, int location, Texture texture);
	public void SetTexture(string variableName, Texture texture)
	{
		int location = GetCachedVariableLocation(variableName);
		SetShaderValueTexture(this, location, texture);
	}

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void UnloadShader(Shader shader);

	public void Dispose()
	{
		UnloadShader(this);
	}
}