using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpoutAPI
{
    /// <summary>
    /// Represents the core implementation of an engine (powers a game).
    /// </summary>
    public interface Engine
    {
        /// <summary>
        /// Gets the name of this game's implementation
        /// </summary>
        /// <returns>name of the implementation</returns>
        String getName();

        /// <summary>
        /// Gets the version of this game's implementation
        /// </summary>
        /// <returns>build version</returns>
        String getVersion();

        /// <summary>
        /// Ends the game instance safely. All worlds, players, and configuration
        /// data is saved, and all threads are ended cleanly.
        /// 
        /// Players will be sent a default disconnect message.
        /// </summary>
        /// <returns>true for the first stop</returns>
        bool Stop();

        /// <summary>
        /// Ends the game instance safely. All worlds, players, and configuration
        /// data is saved, and all threads are ended cleanly.
        /// 
        /// Players will be kicked with the reason message.
        /// </summary>
        /// <param name="reason">reason for stopping the game instance</param>
        /// <returns>true for the first stop</returns>
        bool Stop(String reason);
    }
}
