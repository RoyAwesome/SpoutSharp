using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpoutAPI
{
    public sealed static class Spout
    {
        private static Engine instance;
        public static Engine Engine
        {
            get { return instance; }
            set
            {
                if (instance == null)
                    instance = value;
                else
                    throw new InvalidOperationException("Cannot set the Engine a second time");
            }
        }

        public static void Stop()
        {
            Engine.Stop();
        }
    }
}
