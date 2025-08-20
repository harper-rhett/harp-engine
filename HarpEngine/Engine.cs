global using Raylib_cs;
global using System.Numerics;
global using static Raylib_cs.Raylib;
global using static Raylib_cs.Raymath;
global using static Raylib_cs.Color;

namespace HarpEngine;

public static class Engine
{
	// Input
	private static Game game;
	private static EngineSettings settings; // This may be a mistake... perhaps every value should be accesible from Game. (i.e. Engine.GameWidth)

	// General
	private static RenderTexture2D gameRenderTexture;
	private static Window window = new Window.Bordered(Black);

	public static void Start(Game game, EngineSettings engineSettings)
	{
		Engine.game = game;
		settings = engineSettings;
		Initialize();
		while (!WindowShouldClose())
		{
			MasterUpdate();
			MasterDraw();
		}
	}

	private static void Initialize()
	{
		// Initialize window
		InitWindow(settings.WindowWidth, settings.WindowHeight, settings.WindowName);

		// Initialize game
		gameRenderTexture = LoadRenderTexture(settings.GameWidth, settings.GameHeight);
	}

	private static void MasterUpdate()
	{
		float frameTime = GetFrameTime();
		game.Update(frameTime);
	}

	private static void MasterDraw()
	{
		BeginTextureMode(gameRenderTexture);
		game.Draw();
		EndTextureMode();

		BeginDrawing();
		window.Draw(gameRenderTexture);
		EndDrawing();
	}

	public static void SetWindowBordered(Color borderColor) => window = new Window.Bordered(borderColor);
	public static void SetWindowClipped() => window = new Window.Clipped();
}
