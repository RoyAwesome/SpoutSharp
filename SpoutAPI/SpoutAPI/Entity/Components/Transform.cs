using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK;

namespace SpoutAPI.Entity.Components
{
    class Transform : BasicComponent
    {
        Vector3 position;
        Quaternion rotation;
        Vector3 scale;
        Transform parent;


        public Vector3 Position
        {
            get;
            set;
        }

        public Quaternion Rotation
        {
            get;
            set;
        }

        public Vector3 Scale
        {
            get;
            set;
        }

        public Matrix4 Transform
        {
            get
            {
                return Matrix4.Translation(position) * Matrix4.Rotate(rotation) * Matrix4.Scale(scale);
            }
        }

        public Transform Parent
        {
            get
            {
                return parent;
            }

            set
            {
                parent = value;
            }
        }


        public static Transform operator+(Transform r, Transform l)
        {
            Transform t = new Transform();
            t.position = r.position + l.position;
            t.rotation = r.rotation * l.rotation;
            t.scale = r.scale + l.scale;
            return t;
        }

        public Transform Absoulte
        {
            get
            {
                return parent + this;
            }
        }
       
    }
}
