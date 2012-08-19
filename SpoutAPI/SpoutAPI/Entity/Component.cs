using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpoutAPI.Tick;
using SpoutAPI.Entity.Components;

namespace SpoutAPI.Entity
{
    public interface Component : Tickable
    {
        Entity Parent
        {
            set;
            get;
        }

        Transform Transform
        {
            get;
        }

        Controller Controller
        {
            get;
        }

        void Spawned();

        void OnAttached();

        void OnDetached();

    }
}
