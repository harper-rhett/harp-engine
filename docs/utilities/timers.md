# Timers
> `using HarpEngine.Utilities;`

There are so many ways a game framework can implement timers. HarpEngine takes a new, elegant approach. Timers act like entities, and sync with a scene's timing systems. Timers pause with the scene. Timers speed up and slow down with the scene. Timers are set and go, and then destroy themselves when they are finished. They can even be inherited from for when you need the same timer, over and over.

## Trigger Timer
The trigger timer is simply a timer. It runs for a given amount of time, and then it triggers an event and destroys itself:

```csharp
TriggerTimer waveTimer = new(scene, waveSeconds);
waveTimer.Triggered += NextWave;
waveTimer.RemoveOnTriggered = false;
waveTimer.Start();

void NextWave()
{
	// trigger next wave
	
	waveTimer.Start(); // restart timer
}
```

## Fire Timer
The fire timer is a timer that fires over and over and over. They keep track of sub-frame time, in case your timer is ever faster than your frame rate. It's great for repetitive tasks, like shooting projectiles from a weapon:

```csharp
FireTimer fireTimer = new(scene, cooldownSeconds);
fireTimer.Fired += ShootProjectile;
fireTimer.Start();

void ShootProjectile()
{
	// create a projectile here!
}
```