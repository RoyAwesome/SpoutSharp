
namespace SpoutAPI.Render
{
    /// <summary>
    /// Renderer to attach to a Mesh to change the way the mesh renders
    /// </summary>
    public interface RenderEffect
    {
        /// <summary>
        /// Called before the mesh has been batched.
        /// 
        /// Used for setting the shader or texture.
        /// </summary>
        /// <param name="batcher"></param>
        void PreBatch(Renderer batcher);

        /// <summary>
        /// Called after the mesh has been batched but before the batch has been flushed to the GPU
        /// 
        /// Used to add additional verticies to the model
        /// </summary>
        /// <param name="batcher"></param>
        void PostBatch(Renderer batcher);

        /// <summary>
        /// Called before the mesh is drawn to the scene. Used to set GPU modes and/or effects
        /// </summary>
        /// <param name="batcher"></param>
        void PreDraw(Renderer batcher);

        /// <summary>
        /// Called after the mesh is drawn to the scene. 
        /// 
        /// Used to clean up things done in PreDraw()
        /// </summary>
        /// <param name="batcher"></param>
        void PostDraw(Renderer batcher);
    }
}
