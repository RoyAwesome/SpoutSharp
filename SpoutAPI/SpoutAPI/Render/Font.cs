﻿
namespace SpoutAPI.Render
{
    /// <summary>
    /// Used for drawing text to the screen
    /// </summary>
    public interface Font
    {
        float CharTop
        {
            get;
        }

        float CharHeight
        {
            get;
        }

        float SpaceWidth
        {
            get;
        }

        //Rectangle GetPixelBounds(char ch);
    }
}
