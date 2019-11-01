using Traffic_Lights.Contracts;
using Traffic_Lights.Core;

namespace Traffic_Lights
{
    class StartUp
    {
        static void Main(string[] args)
        {
            IRunable engine = new Engine();
            engine.Run();
        }
    }
}
