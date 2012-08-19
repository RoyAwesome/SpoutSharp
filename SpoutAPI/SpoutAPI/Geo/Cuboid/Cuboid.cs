using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpoutAPI.Geo.Cuboid
{
    public class Cuboid
    {
        internal readonly Point b;
        internal readonly Vector3 size;

        public Cuboid(Point b, Vector3 size)
        {
            this.b = b;
            this.size = size;
        }
    }
}
