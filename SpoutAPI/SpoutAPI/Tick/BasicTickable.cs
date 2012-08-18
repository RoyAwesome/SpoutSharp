using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpoutAPI.Tick
{
    abstract class BasicTickable : Tickable
    {
        public abstract void OnTick(float dt);
       

        public void Tick(float dt)
        {
            OnTick(dt);
        }
    }
}
