using OpenTK;
using SpoutAPI.Geo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpoutAPI.MathHelper;
using SpoutAPI.Geo.Discrete;

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

        public int BlockX
        {
            get { return vector.FloorX(); }
        }

        public int BlockY
        {
            get { return vector.FloorY(); }
        }

        public int BlockZ
        {
            get { return vector.FloorZ(); }
        }

        public int ChunkX
        {
            get { return BlockX / 16; }
        }

        public int ChunkY
        {
            get { return BlockX / 16; }
        }

        public int ChunkZ
        {
            get { return BlockZ / 16; }
        }

        public double getSquaredDistance(Point other)
        {
            if (other == null || world == null || vector == null || other.vector == null || other.world == null || world != other.world)
            {
                return Double.MaxValue;
            }
            double dx = vector.X - other.vector.X;
            double dy = vector.Y - other.vector.Y;
            double dz = vector.Z - other.vector.Z;
            return dx * dx + dy * dy + dz * dz;
        }

        public double getDistance(Point other)
        {
            return Math.Sqrt(getSquaredDistance(other));
        }

        public double getManhattanDistance(Point other)
        {
            if (other == null || world == null || vector == null || other.vector == null || other.world == null || world != other.world)
            {
                return Double.MaxValue;
            }
            return Math.Abs(vector.X - other.vector.X) + Math.Abs(vector.Y - other.vector.Y) + Math.Abs(vector.Z - other.vector.Z);
        }

        public double getMaxDistance(Point other)
        {
            if (other == null || world == null || vector == null || other.vector == null || other.world == null || world != other.world)
            {
                return Double.MaxValue;
            }
            return Math.Max(Math.Abs(vector.X - other.vector.X), Math.Max(Math.Abs(vector.Y - other.vector.Y), Math.Abs(vector.Z - other.vector.Z)));
        }

        public World getWorld()
        {
            return world;
        }

        public override string ToString()
        {
            return base.ToString() + ": " + world.ToString() + ", " + vector.X + " " + vector.Y + " " + vector.Z;
        }

        public override int GetHashCode()
        {
            if (!hashed)
            {
                hashcode = 0;
                hashed = true;
            }
            return hashcode;
        }
    }
}
