global using HarpEngine.Animation;
global using HarpEngine.Graphics;
global using HarpEngine.Utilities;
global using HarpEngine.Windowing;
global using System.Numerics;
global using System.Runtime.InteropServices;
using HarpEngine.Audio;
using HarpEngine.Input;

namespace HarpEngine;

public static class Engine
{
	// Input
	private static Game game;
	private static EngineSettings settings;

	// General
	private static RenderTexture gameRenderTexture;
	public static WindowRenderer WindowRenderer { get; private set; } = new BorderedRenderer(Color.Black);

	// Interface
	public static int GameWidth => settings.GameWidth;
	public static int GameHeight => settings.GameHeight;
	public static int HalfGameWidth { get; private set; }
	public static int HalfGameHeight { get; private set; }

	public static void Initialize(EngineSettings engineSettings)
	{
		// Initialize window
		settings = engineSettings;
		Window.Initialize(settings.WindowWidth, settings.WindowHeight, settings.WindowName);
		HalfGameWidth = GameWidth / 2;
		HalfGameHeight = GameHeight / 2;

		// Initialize game
		AudioDevice.Initialize();
		gameRenderTexture = RenderTexture.Load(settings.GameWidth, settings.GameHeight);
	}

	public static void Start(Game game)
	{
		// Initialization
		Engine.game = game;

		// Game loop
		while (!Window.ShouldClose())
		{
			MasterUpdate();
			MasterDraw();
		}
	}

	private static void MasterUpdate()
	{
		float frameTime = GetFrameTime();
		game.Update(frameTime);
	}

	private static void MasterDraw()
	{
		RenderTexture.BeginDrawing(gameRenderTexture);
		game.Draw();
		RenderTexture.EndDrawing();

		Primitives.Begin();
		WindowRenderer.Draw(gameRenderTexture);
		Primitives.End();
	}

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void SetExitKey(KeyboardKey key);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern float GetFrameTime();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void SetTargetFPS(int fps);

	public static void SetRenderingBordered(Color borderColor) => WindowRenderer = new BorderedRenderer(borderColor);
	public static void SetRenderingClipped() => WindowRenderer = new ClippedRenderer();
}
