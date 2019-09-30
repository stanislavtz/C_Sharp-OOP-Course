using P05_GreedyTimes.Factories;
using P05_GreedyTimes.Models;
using System;

namespace P05_GreedyTimes.Core
{
    public class Engine
    {
        private PreciousFactory factory = new PreciousFactory();

        private Precious precious;

        public void Run()
        {
            int bagCapacity = int.Parse(Console.ReadLine());

            Bag bag = new Bag(bagCapacity);

            string[] caseArgs = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < caseArgs.Length; i += 2)
            {
                string typeOfPreciouse = caseArgs[i];
                int preciouseQuantity = int.Parse(caseArgs[1]);

                this.precious = factory.CreatePrecious(typeOfPreciouse, preciouseQuantity);

                bag.AddPrecious(precious);
            }
        }
    }
}
