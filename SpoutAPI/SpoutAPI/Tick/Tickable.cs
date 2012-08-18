using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpoutAPI.Tick
{
    public interface Tickable
    {
        void OnTick(float dt);

        void Tick(float dt);           
    }
}
