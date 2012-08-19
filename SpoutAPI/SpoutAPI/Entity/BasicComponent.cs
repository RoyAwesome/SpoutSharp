using SpoutAPI.Entity.Components;
using SpoutAPI.Tick;

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
