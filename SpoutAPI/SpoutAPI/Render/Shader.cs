
using OpenTK;
namespace SpoutAPI.Render
{
    public interface Shader
    {
        void SetUniform(string name, int value);

        void SetUniform(string name, float value);

        void SetUniform(string name, Vector2 value);

        void SetUniform(string name, Vector3 value);

        void SetUniform(string name, Vector4 value);

        void SetUniform(string name, Matrix4 value);

        //void SetUniform(string name, Color value);

        void SetUniform(string name, Texture value);

        void Attribute(string name, int size, int type, int stride, long offset, int layout);

        void Assign();
    }
}
