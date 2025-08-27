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
		window.Draw(gameRenderTexture);
		Raylib.EndDrawing();
	}

	public static void SetWindowBordered(Color borderColor) => window = new Window.Bordered(borderColor);
	public static void SetWindowClipped() => window = new Window.Clipped();

	private static void SetWindowState(ConfigFlags configFlags, bool isEnabled)
	{
		if (isEnabled) Raylib.SetWindowState(configFlags);
		else Raylib.ClearWindowState(configFlags);
	}

	public static void SetWindowResizable(bool isResizable) => SetWindowState(ConfigFlags.ResizableWindow, isResizable);
	public static void SetWindowMaximized(bool isMaximized) => SetWindowState(ConfigFlags.MinimizedWindow, isMaximized);
}
