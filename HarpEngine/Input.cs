namespace HarpEngine;

public static class Input
{
	public static bool IsKeyPressed(KeyboardKey keyboardKey)
	{
		return Raylib.IsKeyPressed(keyboardKey);
	}

	public static bool IsKeyRepeating(KeyboardKey keyboardKey)
	{
		return Raylib.IsKeyPressedRepeat(keyboardKey);
	}

	public static bool IsKeyDown(KeyboardKey keyboardKey)
	{
		return Raylib.IsKeyDown(keyboardKey);
	}

	public static bool IsKeyReleased(KeyboardKey keyboardKey)
	{
		return Raylib.IsKeyReleased(keyboardKey);
	}
}
