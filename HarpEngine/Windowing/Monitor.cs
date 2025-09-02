namespace HarpEngine.Windowing;

public class Monitor
{
	public readonly int index;

	internal Monitor(int index)
	{
		this.index = index;
	}

	public static Monitor GetCurrent()
	{
		return new Monitor(Current);
	}

	public static Monitor[] GetAll()
	{
		Monitor[] monitors = new Monitor[Count];
		for (int monitorIndex = 0; monitorIndex < Count; monitorIndex++)
		{
			monitors[monitorIndex] = new Monitor(monitorIndex);
		}
		return monitors;
	}

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern int GetMonitorCount();
	public static int Count => GetMonitorCount();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern int GetCurrentMonitor();
	public static int Current => GetCurrentMonitor();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern Vector2 GetMonitorPosition(int monitor);
	public Vector2 Position => GetMonitorPosition(index);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern int GetMonitorWidth(int monitor);
	public int Width => GetMonitorWidth(index);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern int GetMonitorHeight(int monitor);
	public int Height => GetMonitorHeight(index);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern int GetMonitorPhysicalWidth(int monitor);
	public int WidthInMillimeters => GetMonitorPhysicalWidth(index);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern int GetMonitorPhysicalHeight(int monitor);
	public int HeightInMillimeters => GetMonitorPhysicalHeight(index);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern int GetMonitorRefreshRate(int monitor);
	public int RefreshRate => GetMonitorRefreshRate(index);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern string GetMonitorName(int monitor);
	public string Name => GetMonitorName(index);
}
