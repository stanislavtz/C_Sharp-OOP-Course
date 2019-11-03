using Inferno_Infinity.Core;
using System;

namespace Inferno_Infinity
{
    class AppStartUp
    {
        static void Main(string[] args)
        {
            var engine = new CodeExecute();
            engine.Run();
        }
    }
}
