using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpoutAPI
{
    public interface Server : Engine
    {
        bool Whitelist
        {
            get;
            set;
        }


    }
}
