
namespace SpoutAPI
{
    public interface Server : Engine
    {
        /// <summary>
        /// True if whitelisting is turned on for this server,
        /// False if it is turned off.
        /// </summary>
        bool Whitelist
        {
            get;
            set;
        }


    }
}
