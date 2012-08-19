using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpoutAPI.Render
{
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

        float PixelBounds(char ch)
        {
            get;
        }
    }
}
