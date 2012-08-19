using OpenTK;
using SpoutAPI.Geo.discrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpoutAPI.Geo.Cuboid
{
    public class Point: Vector3
    {
        private readonly static long serialVersionUID = 1L;
        internal readonly World world;
        //Hashcode
        [NonSerialized]
        private volatile bool hashed = false;
        [NonSerialized]
        private volatile int hashcode = 0;

        public Point(World world, Vector3 vector) : base(vector)
        {
            this.world = world;
        }

        public Point(World world, float x, float y, float z) : base(x, y, z)
        {
            this.world = world;
        }

        public Point operator/(int val) 
        {
            Vector3 toDivide = new Vector3(val, val, val);
            
    }
}
