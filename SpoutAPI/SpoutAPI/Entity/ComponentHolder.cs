using SpoutAPI.Tick;

namespace SpoutAPI.Entity
{
    public interface ComponentHolder : Tickable
    {
        T AddComponent<T>() where T : Component;

        bool RemoveComponent<T>() where T : Component;

        T GetComponent<T>() where T : Component;

        bool HasComponent<T>() where T : Component;            

    }
}
