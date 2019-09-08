using Restaurant.Core;
using System;

namespace Restaurant
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var engine = new Engine();

            engine.Run();
        }
    }
}
