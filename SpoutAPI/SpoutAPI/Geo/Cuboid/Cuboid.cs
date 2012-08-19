using OpenTK;
using SpoutAPI.Geo.Discrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpoutAPI.Geo.Cuboid
{
    public class Cuboid : WorldSource
    {
        internal readonly Point bas;
        internal readonly Vector3 size;

        private readonly int x;
        private readonly int y;
        private readonly int z;

        //Hashcode
        [NonSerialized]
        private volatile bool hashed = false;
        [NonSerialized]
        private volatile int hashcode = 0;

        //Vertex
        private Vector3[] vertices = null;

        public Cuboid(Point bas, Vector3 size)
        {
            this.bas = bas;
            this.size = size;
            this.x = (int)(bas.X / size.X);
            this.y = (int)(bas.Y / size.Y);
            this.z = (int)(bas.Z / size.Z);
        }

        public Point Base
        {
            get { return bas; }
        }

        public Vector3 Size
        {
            get { return size; }
        }

        public int X
        {
            get { return x; }
        }

        public int Y
        {
            get { return y; }
        }

        public int Z
        {
            get { return z; }
        }

        public override World getWorld()
        {
            return bas.getWorld();
        }

        public static bool operator ==(Cuboid l, Cuboid r)
        {
            if (l.hashcode == r.hashcode)
            {
                return true;
            }
            return false;
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

        public Vector3[] getVertices()
        {
            if (vertices == null)
            {
                vertices = new Vector3[8];

                // Front
                vertices[0] = new Vector3(bas.X, bas.Y, bas.Z + size.Z);
                vertices[1] = new Vector3(bas.X + size.X, bas.Y, bas.Z + size.Z);
                vertices[2] = new Vector3(bas.X + size.X, bas.Y + size.Y, bas.Z + size.Z);
                vertices[3] = new Vector3(bas.X, bas.Y + size.Y, bas.Z + size.Z);
                // Back
                vertices[4] = new Vector3(bas.X, bas.Y, bas.Z);
                vertices[5] = new Vector3(bas.X + size.X, bas.Y, bas.Z);
                vertices[6] = new Vector3(bas.X + size.X, bas.Y + size.Y, bas.Z);
                vertices[7] = new Vector3(bas.X, bas.Y + size.Y, bas.Z);
            }
            return vertices;
        }

        public bool contains(Vector3 vec)
        {
            Vector3 max = bas.vector + size;
            return (bas.X <= vec.X && vec.X < max.X) && (bas.Y <= vec.Y && vec.Y < max.Y) && (bas.Z <= vec.Z && vec.Z < max.Z);
        }

        public override string ToString()
        {
            return base.ToString() + ": Cuboid: " + x + ", " + y + " " + z;
        }
    }
}
