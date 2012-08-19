using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spout
{
    class Program
    {
        static void Main(string[] args)
        {
          
#if CLIENT
            SpoutEngine engine = new SpoutClient();
#else
            SpoutEngine engine = new SpoutServer();
#endif
            
        }
    }
}
