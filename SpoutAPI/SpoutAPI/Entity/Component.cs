using SpoutAPI.Entity.Components;
using SpoutAPI.Tick;

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
