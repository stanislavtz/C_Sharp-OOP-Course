using P05_GreedyTimes.Factories;
using P05_GreedyTimes.Models;
using System;
using System.Reflection;

namespace P05_GreedyTimes.Core
{
    public class Engine
    {
        private readonly PreciousFactory factory = new PreciousFactory();

        private IPrecious precious;

        public void Run()
        {
            int bagCapacity = int.Parse(Console.ReadLine());

            Bag bag = new Bag(bagCapacity);
            
            string[] caseArgs = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < caseArgs.Length; i += 2)
            {
                string typeOfPrecious = caseArgs[i];
                int preciousQuantity = int.Parse(caseArgs[i + 1]);

                this.precious = factory.CreatePrecious(typeOfPrecious, preciousQuantity);

                bag.AddPrecious(precious);
            }

            foreach (var item in bag.BagContent)
            {
                Console.WriteLine($"{item.Name} ==> {item.Quantity}");
            }
        }
    }
}
