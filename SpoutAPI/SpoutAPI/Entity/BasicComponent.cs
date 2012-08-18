using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpoutAPI.Tick;

namespace SpoutAPI.Entity
{
    public abstract class BasicComponent : BasicTickable, Component
    {
        public abstract void Init();
       
        public void OnAttached()
        {
           
        }

        public void OnDetached()
        {
           
        }
             
    }
}
