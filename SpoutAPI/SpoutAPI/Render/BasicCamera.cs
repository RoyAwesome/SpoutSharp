using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpoutAPI.Render
{
    public class BasicCamera : Camera
    {
        private Matrix4 projection;
        private Matrix4 view;
        private ViewFrustum frustum = new ViewFrustum();

        public BasicCamera(Matrix4 projection, Matrix4 view)
        {
            this.projection = projection;
            this.view = view;
        }

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
            frustum.update(projection, view);
        }

        public override ViewFrustum getFrustum()
        {
            return frustum;
        }
    }
}
