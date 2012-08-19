using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK;

namespace SpoutAPI.Entity.Components
{
    public class Transform : BasicComponent
    {
        static Transform Empty = new Transform();


        Vector3 position = Vector3.Zero;
        Quaternion rotation = Quaternion.Identity;
        Vector3 scale = Vector3.One;
        Transform parentTransform = Empty;


        public Vector3 Position
        {
            get { return position; }
            set { position = value; }
        }

        public Quaternion Rotation
        {
            get { return rotation; }
            set { rotation = value; }
        }

        public Vector3 Scale
        {
            get { return scale; }
            set { scale = value; }
        }

        public Matrix4 TransformaMatrix
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
                return parentTransform;
            }

            set
            {
                parentTransform = value;
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
               return parentTransform + this;
            }
        }


        public override void Spawned()
        {
            
        }

        public override void OnTick(float dt)
        {
            
        }
    }
}
