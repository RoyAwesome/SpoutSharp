using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpoutAPI.Tick;

namespace SpoutAPI.Entity
{
    public abstract class BasicComponent : BasicTickable, Component
    {
     
        internal Entity parent;

        Entity Parent
        {
            get { return parent; }
           
        }


        public abstract void Init();
       
        public void OnAttached()
        {
           
        }

        public void OnDetached()
        {
           
        }
             
    }
}
