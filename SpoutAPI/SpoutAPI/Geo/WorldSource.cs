using SpoutAPI.Geo.Discrete;

namespace SpoutAPI.Geo
{
    /// <summary>
    /// Represents an object that can be contained within a World
    /// </summary>
    public interface WorldSource
    {
        /// <summary>
        /// Gets the world
        /// </summary>
        /// <returns>Object representing the world</returns>
        World getWorld();
    }
}
