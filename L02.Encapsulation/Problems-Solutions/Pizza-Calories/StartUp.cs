using Pizza_Calories.Core;
using Pizza_Calories.Core.Contracts;

namespace Pizza_Calories
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IEngine engine = new Engine();

            engine.Run();
        }
    }
}
