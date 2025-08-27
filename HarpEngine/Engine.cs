global using Raylib_cs;
global using System.Numerics;
global using static Raylib_cs.Color;
global using static HarpEngine.Graphics;
global using static HarpEngine.Input;

namespace HarpEngine;

public static class Engine
{
	// Input
	private static Game game;
	private static EngineSettings settings;

	// General
	private static RenderTexture2D gameRenderTexture;
	public static Window Window { get; private set; } = new BorderedWindow(Black);

	// Interface
	public static int GameWidth => settings.GameWidth;
	public static int GameHeight => settings.GameHeight;
	public static int HalfGameWidth { get; private set; }
	public static int HalfGameHeight { get; private set; }

	public static void Initialize(EngineSettings engineSettings)
	{
		// Initialize window
		settings = engineSettings;
		Raylib.InitWindow(settings.WindowWidth, settings.WindowHeight, settings.WindowName);
		HalfGameWidth = GameWidth / 2;
		HalfGameHeight = GameHeight / 2;
		
		// Initialize game
		gameRenderTexture = Raylib.LoadRenderTexture(settings.GameWidth, settings.GameHeight);
	}

	public static void Start(Game game)
	{
		// Initialization
		Engine.game = game;

		// Game loop
		while (!Raylib.WindowShouldClose())
		{
			MasterUpdate();
			MasterDraw();
		}
	}

	private static void MasterUpdate()
	{
		float frameTime = Raylib.GetFrameTime();
		game.Update(frameTime);
	}

	private static void MasterDraw()
	{
		Raylib.BeginTextureMode(gameRenderTexture);
		game.Draw();
		Raylib.EndTextureMode();

		Raylib.BeginDrawing();
		Window.Draw(gameRenderTexture);
		Raylib.EndDrawing();
	}

	public static void SetRenderingBordered(Color borderColor) => Window = new BorderedWindow(borderColor);
	public static void SetRenderingClipped() => Window = new ClippedWindow();
}
