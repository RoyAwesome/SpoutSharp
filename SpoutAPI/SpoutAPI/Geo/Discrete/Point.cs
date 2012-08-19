using OpenTK;
using SpoutAPI.Geo.discrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpoutAPI.Math.Vector3Ext;

namespace SpoutAPI.Geo.Cuboid
{
    [Serializable]
    public class Point
    {
        internal readonly Vector3 vector;
        internal readonly World world;
        //Hashcode
        [NonSerialized]
        private volatile bool hashed = false;
        [NonSerialized]
        private volatile int hashcode = 0;

        public Point(World world, Vector3 vector)
        {
            this.world = world;
            this.vector = vector;
        }

        public Point(World world, float x, float y, float z)
        {
            this.world = world;
            vector = new Vector3(x, y, z);
        }

        public static bool operator ==(Point l, Point r)
        {
            if (l.world != r.world || l.vector != r.vector)
            {
                return false;
            }
            return true;
        }

        public static bool operator !=(Point l, Point r)
        {
            if (l.world == r.world || l.world == r.world)
            {
                return false;
            }
            return true;
        }

        public static Point operator +(Point l, Point r)
        {
            if (l.world != r.world)
            {
                throw new InvalidOperationException("Cannot add two points with mismatch worlds together");
            }
            return new Point(l.world, Vector3.Add(l.vector, r.vector));
        }

        public static Point operator -(Point l, Point r)
        {
            if (l.world != r.world)
            {
                throw new InvalidOperationException("Cannot subtract two points with mismatch worlds together");
            }
            return new Point(l.world, Vector3.Subtract(l.vector, r.vector));
        }

        public static Point operator /(Point l, Point r)
        {
            if (l.world != r.world)
            {
                throw new InvalidOperationException("Cannot divide two points with mismatch worlds together");
            }
            return new Point(l.world, Vector3.Divide(l.vector, r.vector));
        }

        public static Point operator *(Point l, Point r)
        {
            if (l.world != r.world)
            {
                throw new InvalidOperationException("Cannot multiply two points with mismatch worlds together");
            }
            return new Point(l.world, Vector3.Multiply(l.vector, r.vector));
        }

        public int BlockX()
        {
            return vector.FloorX();
        }

        public int getBlockY()
        {
            return (int)Math.Floor(vector.Y);
        }

        public int getBlockZ()
        {
            return (int)Math.Floor(vector.Z);
        }

        public int getChunkX()
        {
            return vector.  
    }  
}
