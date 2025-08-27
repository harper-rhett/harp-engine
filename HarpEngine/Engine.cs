global using System.Numerics;
global using HarpEngine.Utilities;
global using HarpEngine.Animation;
global using HarpEngine.Windowing;
global using HarpEngine.Graphics;
global using System.Runtime.InteropServices;

namespace HarpEngine;

public static class Engine
{
	// Input
	private static Game game;
	private static EngineSettings settings;

	// General
	private static RenderTexture2D gameRenderTexture;
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
		gameRenderTexture = Textures.LoadRenderTexture(settings.GameWidth, settings.GameHeight);
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
		RenderTexture2D.BeginDrawing(gameRenderTexture);
		game.Draw();
		RenderTexture2D.EndDrawing();

		Drawing.Begin();
		WindowRenderer.Draw(gameRenderTexture);
		Drawing.End();
	}

	[DllImport("raylib.dll", CallingConvention = CallingConvention.Cdecl)]
	private static extern float GetFrameTime();

	public static void SetRenderingBordered(Color borderColor) => WindowRenderer = new BorderedRenderer(borderColor);
	public static void SetRenderingClipped() => WindowRenderer = new ClippedRenderer();
}
