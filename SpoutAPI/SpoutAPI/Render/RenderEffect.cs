using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpoutAPI.Render
{
    public interface RenderEffect
    {
        void PreBatch(Renderer batcher);

        void PostBatch(Renderer batcher);

        /**
         * Called before the mesh is drawn to the scene. Used to set GPU modes
         * and/or effects
         */
        public void preDraw(Renderer batcher);

        /**
         * Called after the mesh is drawn to the scene
         *
         * Used to clean up things done in preDraw()
         */
        public void postDraw(Renderer batcher);
    }
}
