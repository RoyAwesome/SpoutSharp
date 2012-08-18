using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpoutAPI.Tick;

namespace SpoutAPI.Entity
{
    interface ComponentHolder : Tickable
    {
        T AddComponent<T>() where T : Component;

        bool RemoveComponent<T>() where T : Component;

        T GetComponent<T>() where T : Component;

        bool HasComponent<T>() where T : Component;            

    }
}
