using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpoutAPI.Render
{
    public interface Camera
    {
        /// <summary>
        /// Projection matrix of the camera.
        /// </summary>
        Matrix4 Projection
        {
            get;
        }

        /// <summary>
        /// View matrix of the camera.
        /// </summary>
        Matrix4 View
        {
            get;
        }

        /// <summary>
        /// Updates the view matrix.
        /// </summary>
        void UpdateView();

        /// <summary>
        /// View frustum of the camera.
        /// </summary>
        ViewFrustum Frustum
        {
            get;
        }
    }
}