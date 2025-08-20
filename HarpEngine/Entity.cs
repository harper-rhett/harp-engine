using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarpEngine;

public abstract class Entity
{
	public World World;

	public abstract void Update(float frameTime);
	public abstract void Draw();
	public virtual void OnRemove() { }
}
