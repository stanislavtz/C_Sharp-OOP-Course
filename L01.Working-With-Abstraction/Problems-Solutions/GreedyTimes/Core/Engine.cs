using System;

using P05_GreedyTimes.Models;
using P05_GreedyTimes.Factories;

namespace P05_GreedyTimes.Core
{
    public class Engine
    {
        private readonly PreciousFactory factory;

        private IPrecious precious;

        public Engine(PreciousFactory factory)
        {
            this.factory = factory;
        }

        public void Run()
        {
            long bagCapacity = long.Parse(Console.ReadLine());

            Bag bag = new Bag(bagCapacity);

            string[] caseArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < caseArgs.Length; i += 2)
            {
                string preciousType = caseArgs[i];
                long preciousQuantity = long.Parse(caseArgs[i + 1]);

                this.precious = this.factory.CreatePrecious(preciousType, preciousQuantity);

                bag.AddPrecious(precious);
            }

            Console.WriteLine(bag);
        }
    }
}
