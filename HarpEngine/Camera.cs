using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarpEngine;

public enum CameraMode
{
	RenderWindow,
	RenderSpace2D,
	RenderSpace3D
}

public class Camera
{
	// General
	internal CameraMode Mode;

	// 2D
	private Camera2D camera2D;
	public Vector2 Position2D
	{
		get => camera2D.Target;
		set => camera2D.Target = value;
	}

	public void RenderWindow()
	{
		Mode = CameraMode.RenderWindow;
	}

	public void RenderSpace2D()
	{
		Vector2 centeredOffset = new(Engine.HalfGameWidth, Engine.HalfGameHeight);
		camera2D = new(centeredOffset, Vector2.Zero, 0, 1);
		Mode = CameraMode.RenderSpace2D;
	}

	internal void Update(float frameTime)
	{
		if (Mode is CameraMode.RenderWindow) return;
	}

	internal void Begin()
	{
		if (Mode is CameraMode.RenderSpace2D) Raylib.BeginMode2D(camera2D);
	}

	internal void End()
	{
		if (Mode is CameraMode.RenderSpace2D) Raylib.EndMode2D();
	}
}
