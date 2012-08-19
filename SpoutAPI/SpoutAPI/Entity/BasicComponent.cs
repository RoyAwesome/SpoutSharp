using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpoutAPI.Tick;
using SpoutAPI.Entity.Components;

namespace SpoutAPI.Entity
{
    public abstract class BasicComponent : BasicTickable, Component
    {

        internal Entity parent;

        public Entity Parent
        {
            get { return parent; }
            set
            {
                parent = value;
                OnAttached();
            }
        }

        public Transform Transform
        {
            get { return Parent.Transform; }
        }

        public Controller Controller
        {
            get { return Parent.Controller; }
        }

        public abstract void Spawned();

        public virtual void OnAttached()
        {

        }

        public virtual void OnDetached()
        { 

        }
    }
}
