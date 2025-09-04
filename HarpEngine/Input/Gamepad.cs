namespace HarpEngine.Input;

public class Gamepad
{
	private int index;

	internal Gamepad(int index)
	{
		this.index = index;
	}

	public static Gamepad GetGamepad(int index)
	{
		if (IsGamepadAvailable(index)) return new(index);
		else return null;
	}

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern bool IsGamepadAvailable(int gamepadIndex);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern string GetGamepadName(int gamepadIndex);
	public string Name => GetGamepadName(index);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern bool IsGamepadButtonPressed(int gamepadIndex, GamepadButton button);
	public bool IsButtonPressed(GamepadButton button) => IsGamepadButtonPressed(index, button);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern bool IsGamepadButtonDown(int gamepadIndex, GamepadButton button);
	public bool IsButtonDown(GamepadButton button) => IsGamepadButtonDown(index, button);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern bool IsGamepadButtonReleased(int gamepadIndex, GamepadButton button);
	public bool IsButtonReleased(GamepadButton button) => IsGamepadButtonReleased(index, button);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern GamepadButton GetGamepadButtonPressed();
	public GamepadButton LastButtonPressed => GetGamepadButtonPressed();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern float GetGamepadAxisMovement(int gamepadIndex, GamepadAxis axis);
	public float GetAxis(GamepadAxis axis) => GetGamepadAxisMovement(index, axis);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern void SetGamepadVibration(int gamepadIndex, float leftMotor, float rightMotor, float duration);
	public void Vibrate(float leftMotor, float rightMotor, float duration) => SetGamepadVibration(index, leftMotor, rightMotor, duration);
}
