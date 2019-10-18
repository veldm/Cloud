using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cloud_DLL;

namespace DebugConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Server S = new Server();
            S.Connect(907);
        }
    }
}
