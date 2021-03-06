﻿using OpenTK;
using SpoutAPI.Geo.Discrete;
using SpoutAPI.MathHelper;
using System;

namespace SpoutAPI.Geo.Cuboid
{
    [Serializable]
    public class Point : WorldSource
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
            if (vector == null)
            {
                throw new NullReferenceException("Trying to set a null vector for a Point!");
            }
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

        public float X
        {
            get { return vector.X; }
        }

        public float Y
        {
            get { return vector.Y; }
        }

        public float Z
        {
            get { return vector.Z; }
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

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            return this == obj;
        }
    }
}
