using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpoutAPI.Render
{
    public interface Renderer
    {
        /// <summary>
        /// Begins batching calls
        /// </summary>
         void Begin();

        /// <summary>
        /// Ends batching and flushes cache to the GPU
        /// </summary>
         void End();

        /// <summary>
        /// Renders the batch
        /// </summary>
        /// <param name="material">RenderMaterial to render with</param>
         void Render(RenderMaterial material);

         void AddVertex(float x, float y, float z, float w);

         void AddVertex(float x, float y, float z);

         void AddVertex(float x, float y);

         void AddVertex(Vector3 vertex);

         void AddVertex(Vector2 vertex);

         void AddVertex(Vector4 vertex);

         void AddColor(float r, float g, float b);

         void AddColor(float r, float g, float b, float a);

        // void AddColor(Color color);

         void AddNormal(float x, float y, float z, float w);

         void AddNormal(float x, float y, float z);

         void AddNormal(Vector3 vertex);

         void AddNormal(Vector4 vertex);

         void AddTexCoord(float u, float v);

         void AddTexCoord(Vector2 uv);

         void EnableColors();

         void EnableNormals();

         void EnableTextures();

         int VertexCount
         {
             get;
         }
    }
}
