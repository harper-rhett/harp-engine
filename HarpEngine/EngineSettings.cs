using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarpEngine;

public struct EngineSettings
{
	public int WindowWidth;
	public int WindowHeight;
	public string WindowName;

	public EngineSettings()
	{
		WindowWidth = 500;
		WindowHeight = 500;
		WindowName = "Harp Engine";
	}
}
