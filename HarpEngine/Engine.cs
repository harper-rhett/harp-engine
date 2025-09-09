global using HarpEngine.Animation;
global using HarpEngine.Graphics;
global using HarpEngine.Utilities;
global using HarpEngine.Windowing;
global using HarpEngine.Audio;
global using HarpEngine.Input;
global using HarpEngine.Shapes;
global using System.Numerics;
global using System.Runtime.InteropServices;

namespace HarpEngine;

public static class Engine
{
	// Input
	private static Game game;
	private static EngineSettings settings;

	// General
	private static RenderTexture gameRenderTexture;

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
		if (frameTime > 0.1f) frameTime = 0.1f;
		game.Update(frameTime);
		Window.Renderer.Update(gameRenderTexture);
	}

	private static void MasterDraw()
	{
		RenderTexture.BeginDrawing(gameRenderTexture);
		game.Draw();
		RenderTexture.EndDrawing();

		Drawing.Begin();
		Window.Renderer.Draw(gameRenderTexture);
		Drawing.End();
	}

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern float GetFrameTime();

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void SetTargetFPS(int fps);

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	public static extern void TakeScreenshot(string fileName);
}
