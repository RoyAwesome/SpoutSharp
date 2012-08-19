using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpoutAPI.Render
{
    /// <summary>
    /// Render Mode for the client
    /// 
    /// GL11 - OpenGL 1.1 Client Profile
    /// GL20 - OpenGL 2.0 Client Profile
    /// GL30 - OpenGL 3.2 Client Profile (Default)
    /// 
    /// </summary>
    enum RenderMode
    {
        GL11,
        GL20,
        GL30,
        GLES20
    }
}
