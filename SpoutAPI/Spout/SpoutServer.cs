﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpoutAPI;

namespace Spout
{
    class SpoutServer : SpoutEngine, Server
    {
        public bool Whitelist
        {
            get;
            set;
        }
    }
}
