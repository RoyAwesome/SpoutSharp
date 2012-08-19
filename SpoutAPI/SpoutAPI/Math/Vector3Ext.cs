using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpoutAPI.MathHelper
{
    public static class Vector3Ext
    {
        public static int FloorX(this Vector3 ext)
        {
            return (int) System.Math.Floor(ext.X); 
        }

        public static int FloorY(this Vector3 ext)
        {
            return (int)System.Math.Floor(ext.Y);
        }

        public static int FloorZ(this Vector3 ext)
        {
            return (int)System.Math.Floor(ext.Z);
        }
    }
}
