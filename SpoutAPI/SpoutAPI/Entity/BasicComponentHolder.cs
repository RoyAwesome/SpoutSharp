using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpoutAPI.Tick;

namespace SpoutAPI.Entity
{
    public class BasicComponentHolder : BasicTickable, ComponentHolder
    {
        Dictionary<System.Type, Component> components = new Dictionary<Type, Component>();
        
        public override void OnTick(float dt)
        {
            foreach (Component c in components.Values)
            {
                c.Tick(dt);
            }
        }

        public T AddComponent<T>() where T : Component
        {
            if (this.HasComponent<T>()) return (T)components[typeof(T)];

            System.Type componentType = typeof(T);
            Component comp = (Component) componentType.GetConstructor(System.Type.EmptyTypes).Invoke(null);

            components[componentType] = comp;

            comp.Init();            

            return (T)comp;
        }

        public bool RemoveComponent<T>() where T : Component
        {
            if (!HasComponent<T>()) return false;

            components[typeof(T)].OnDetached();

            components[typeof(T)] = null;

            return true;
        }

        public T GetComponent<T>() where T : Component
        {
            if(!HasComponent<T>()) return default(T);

            return (T)components[typeof(T)];
        }

        public bool HasComponent<T>() where T : Component
        {
            return components.ContainsKey(typeof(T));
        }
    }
}
