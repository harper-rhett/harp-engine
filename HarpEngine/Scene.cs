namespace HarpEngine;

public class Scene
{
	// Interface
	public Entities Entities { get; private set; } = new();
	public Camera Camera;
	/// <summary>Seconds since creation that this world has been unpaused.</summary>
	public float Time { get; private set; }
	/// <summary>If the update loop is paused. The draw loop is unaffected/</summary>
	public bool IsPaused;

	public Scene()
	{
		Camera = new();
	}

	public void Update(float frameTime)
	{
		if (IsPaused) return;
		Time += frameTime;

		Entities.ProcessAdditions();
		UpdateEntities(frameTime);
		Entities.ProcessRemovals();
		Camera.Update(frameTime);
	}

	private void UpdateEntities(float frameTime)
	{
		foreach (Entity entity in Entities.InUpdateOrder)
		{
			if (entity.IsUpdating) entity.Update(frameTime);
		}
	}

	public void Draw()
	{
		DrawGame();
		DrawGUI();
	}

	private void DrawGame()
	{
		Camera.Begin();
		foreach (Entity entity in Entities.InDrawOrder)
		{
			if (entity.IsRendering) entity.Draw();
		}
		Camera.End();
	}

	private void DrawGUI()
	{
		foreach (Entity entity in Entities.InDrawOrder)
		{
			if (entity.IsRendering) entity.DrawGUI();
		}
	}
}
