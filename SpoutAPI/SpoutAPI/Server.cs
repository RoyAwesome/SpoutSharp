using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpoutAPI
{
    public interface Server : Engine
    {
        /// <summary>
        /// If the server has whitelisting turned on or off.
        /// </summary>
        bool Whitelist
        {
            get;
            set;
        }


    }
}
