namespace HarpEngine;

public class Scene
{
	// Interface
	public Entities Entities { get; private set; } = new();
	/// <summary>Seconds since creation that this world has been unpaused.</summary>
	public float Time { get; private set; }
	/// <summary>If the update loop is paused. The draw loop is unaffected/</summary>
	public bool IsPaused;
	public Camera Camera;
	public float SpeedModifier = 1;

	public void Update(float frameTime)
	{
		if (IsPaused) return;
		Time += frameTime * SpeedModifier;

		Entities.ProcessAdditions();
		Entities.ProcessMoves();
		UpdateEntities(frameTime);
		Entities.ProcessRemovals();
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
		if (Camera is not null) Camera.Begin();
		foreach (Entity entity in Entities.InDrawOrder)
		{
			if (entity.IsRendering) entity.Draw();
		}
		if (Camera is not null) Camera.End();
	}

	private void DrawGUI()
	{
		foreach (Entity entity in Entities.InDrawOrder)
		{
			if (entity.IsRendering) entity.DrawGUI();
		}
	}
}
