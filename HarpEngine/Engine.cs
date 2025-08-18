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
	private static EngineSettings settings;

	// General
	private static RenderTexture2D gameRenderTexture;
	private static Rectangle gameRectangle;
	private static Rectangle windowRectangle;

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
		windowRectangle = new(0, 0, settings.WindowWidth, settings.WindowHeight);

		// Initialize game
		gameRenderTexture = LoadRenderTexture(settings.GameWidth, settings.GameHeight);
		gameRectangle = new(0, 0, settings.GameWidth, -settings.GameHeight);
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
		DrawTexturePro(gameRenderTexture.Texture, gameRectangle, windowRectangle, Vector2.Zero, 0, White);
		EndDrawing();
	}
}
