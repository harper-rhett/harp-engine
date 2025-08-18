using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarpEngine;

public abstract class Runtime
{
	protected abstract void Update(float frameTime);
	protected abstract void Draw();
}
