using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpoutAPI.Tick;

namespace SpoutAPI.Entity
{
    public interface Component : Tickable
    {
        void Init();

        void OnAttached();

        void OnDetached();

    }
}
