using SpoutAPI.Geo.Discrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
