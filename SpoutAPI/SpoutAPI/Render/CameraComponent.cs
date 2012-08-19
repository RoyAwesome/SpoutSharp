using OpenTK;
using SpoutAPI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpoutAPI.Render
{
    public class CameraComponent : BasicComponent, Camera
    {
        private readonly ViewFrustum frustum = new ViewFrustum();
        private Matrix4 projection;
        private Matrix4 view;

        public override Matrix4 Projection
        {
            get { return projection; }
        }

        public override Matrix4 View
        {
            get { return view; }
        }

        public override void UpdateView()
        {
            view = Matrix4.Rotate(Parent.Transform.Rotation) * Matrix4.Translation(Parent.Transform.Position);
        }

        public override void OnTick(float dt)
        {
            UpdateView();
            frustum.update(projection, view);
        }

        public override void OnAttached()
        {
            projection = Matrix4.CreatePerspectiveFieldOfView(90f, 4.0f / 3.0f, .001f, 1000f);
            UpdateView();
            frustum.update(projection, view);
        }

        public override ViewFrustum Frustum
        {
            get { return frustum; }
        }
    }
}