using P05_GreedyTimes.Core;
using P05_GreedyTimes.Factories;

namespace P05_GreedyTimes
{

    public class StartUp
    {
        static void Main(string[] args)
        {
            PreciousFactory factory = new PreciousFactory();
            Engine engine = new Engine(factory);

            engine.Run();
        }
    }
}