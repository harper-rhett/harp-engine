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
	private static Window window = new Window.Bordered(Black);

	// Interface
	public static int GameWidth => settings.GameWidth;
	public static int GameHeight => settings.GameHeight;
	public static int HalfGameWidth { get; private set; }
	public static int HalfGameHeight { get; private set; }

	public static void Initialize(EngineSettings engineSettings)
	{
		// Initialize window
		settings = engineSettings;
		InitWindow(settings.WindowWidth, settings.WindowHeight, settings.WindowName);
		HalfGameWidth = GameWidth / 2;
		HalfGameHeight = GameHeight / 2;

		// Initialize game
		gameRenderTexture = LoadRenderTexture(settings.GameWidth, settings.GameHeight);
	}

	public static void Start(Game game)
	{
		// Initialization
		Engine.game = game;

		// Game loop
		while (!WindowShouldClose())
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
