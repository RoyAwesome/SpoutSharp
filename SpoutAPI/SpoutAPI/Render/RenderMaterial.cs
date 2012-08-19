using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpoutAPI.Render
{
    public interface RenderMaterial
    {
        /// <summary>
        /// Returns a material param or null if that doesn't exist
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Object getValue(String name);

        /// <summary>
        /// Returns the shader specified in the material
        /// </summary>
        Shader Shader
        {
            get;
        }

        /// <summary>
        /// Assigns the current shader and prepairs the material for rendering
        /// </summary>
        void Assign();

        /// <summary>
        /// Called right before rendering
        /// </summary>
        void PreRender();

        /// <summary>
        /// Called right after rendering
        /// </summary>
        void PostRender();
    }
}
