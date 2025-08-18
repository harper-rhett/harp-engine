global using static Raylib_cs.Raylib;
global using static Raylib_cs.Raymath;

namespace HarpEngine;

public static class Engine
{
	private static Game game;
	private static EngineSettings settings;

	public static void Start(Game game, EngineSettings engineSettings)
	{
		Engine.game = game;
		settings = engineSettings;
		Initialize();
		while (!WindowShouldClose())
		{
			RunUpdate();
			RunDraw();
		}
	}

	private static void Initialize()
	{
		InitWindow(settings.WindowWidth, settings.WindowHeight, settings.WindowName);
	}

	private static void RunUpdate()
	{
		float frameTime = GetFrameTime();
		game.Update(frameTime);
	}

	private static void RunDraw()
	{
		game.Draw();

		BeginDrawing();
		EndDrawing();
	}
}
