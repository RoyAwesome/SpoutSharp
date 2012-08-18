using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpoutAPI.Tick;
using SpoutAPI.Entity.Components;

namespace SpoutAPI.Entity
{
    public interface Entity : Tickable
    {
        int getId();

        Guid getGuid();

        Transform Transform
        {
            get;
        }

        Controller Controller
        {
            get;
            set;
        }
    }
}
