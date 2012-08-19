
namespace SpoutAPI.Tick
{
    public abstract class BasicTickable : Tickable
    {
        public abstract void OnTick(float dt);
       

        public void Tick(float dt)
        {
            OnTick(dt);
        }
    }
}
