
namespace SpoutAPI.Tick
{
    public interface Tickable
    {
        void OnTick(float dt);

        void Tick(float dt);           
    }
}
