# HarpEngine
Harp Engine is a (currently) 2D C# game development framework built on the [Raylib Graphics Library](https://www.raylib.com/). It is outfitted with tools designed to make prototyping simple, projects scalable, and scope-creep manageable.

# Features
- Scene management system (with entities, update loops, and layers)
- Window resolution management (scale or clip game content automatically)
- Particle engine (simple, manageable, and extendible)
- Extended randomization (C#'s `Random` class is simply not enough)
- Time control (pause scenes, distort time, and create intuitive timers)
- Easing tools (interpolation has never been simpler)
- Transforms (opt-in parent-child system)

# Coming Soon
- 3D (1.5x more dimensions!)
- Physics engine (boing, clank, smack)
- Collision helpers (shape hug testers)
- Sprite animation system (yes, this is very important, just hol up a sec)
- Noise generation (Simplex, Perlin, Cellular, Drum and Bass)
- Particle lifetime gradients (red fish, blue fish, red to blue to green fish)

# Raylib Bindings
If you are familiar with Raylib, the bindings I have created may seem somewhat alien to you. I have very carefully modernized them to align with a typical C# workflow. For instance, in pure Raylib you would call `LoadTexture(filePath)` and then `DrawTexture(myTexture, x, y, color)`. In HarpEngine, the same is accomplished with `using graphics`, `Texture.Load(filePath)`, and finally `Texture.Draw(x, y, color)`. Some bindings are less obvious than others, but designed to abstract C from C# development.

Additionally, not all bindings are implemented. I will be adding more as requested and with care.

# Getting Started


# Examples


# Building
