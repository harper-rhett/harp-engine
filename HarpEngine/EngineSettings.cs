using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarpEngine;

public struct EngineSettings
{
	// Window
	public int WindowWidth;
	public int WindowHeight;
	public string WindowName;

	// Game
	public int GameWidth;
	public int GameHeight;

	public EngineSettings()
	{
		WindowWidth = 800;
		WindowHeight = 800;
		WindowName = "Harp Engine";

		GameWidth = 256;
		GameHeight = 256;
	}
}
