using P05_GreedyTimes.Factories;
using P05_GreedyTimes.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_GreedyTimes.Core
{
    public class Engine
    {
        private readonly PreciousFactory factory = new PreciousFactory();

        private IPrecious precious;

        public void Run()
        {
            int bagCapacity = int.Parse(Console.ReadLine());

            int totalGold = 0;

            string[] caseArgs = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, List<IPrecious>> bag = new Dictionary<string, List<IPrecious>>();

            for (int i = 0; i < caseArgs.Length; i += 2)
            {
                string typeOfPrecious = caseArgs[i];
                int preciousQuantity = int.Parse(caseArgs[i + 1]);

                this.precious = factory.CreatePrecious(typeOfPrecious, preciousQuantity);

                if (precious.GetType().Name == "Gold")
                {
                    if (!bag.ContainsKey("Gold"))
                    {
                        bag.Add("Gold", new List<IPrecious>());
                    }

                    bool isPossibleToAddGold = totalGold + precious.Quantity <= bagCapacity;

                    if (!isPossibleToAddGold)
                    {
                        continue;
                    }
               
                    bag["Gold"].Add(precious);
                    totalGold = bag["Gold"].Sum(s => s.Quantity);
                }
            }

            Console.WriteLine(totalGold);
        }
    }
}
