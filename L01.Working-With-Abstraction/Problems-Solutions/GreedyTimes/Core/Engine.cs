using P05_GreedyTimes.Factories;
using P05_GreedyTimes.Models;
using System;
using System.Linq;

namespace P05_GreedyTimes.Core
{
    public class Engine
    {
        private PreciousFactory factory = new PreciousFactory();

        private IPrecious precious;
        private int totalGold;
        private int totalGems;
        private int totalCash;

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

                if (typeOfPrecious == "Gold")
                {
                    this.totalGold = bag.BagContent["Gold"].Sum(v => v.Quantity);
                    bool isMoreThenBagCapacity = this.totalGold > bagCapacity;

                    if (isMoreThenBagCapacity)
                    {
                        // ?????????????????????????????????????????
                    }

                    bag.AddPrecious(precious);
                }
                else if (typeOfPrecious == "Gem")
                {
                    this.totalGems = bag.BagContent["Gems"].Sum(v => v.Quantity) + preciousQuantity;
                    bool IsMoreThenGold = this.totalGems > this.totalGold;

                    if (IsMoreThenGold)
                    {
                        continue;
                    }

                    bag.AddPrecious(precious);
                }
                else if (typeOfPrecious == "Cash")
                {
                    this.totalCash = bag.BagContent["Cash"].Sum(v => v.Quantity) + preciousQuantity;
                    bool IsMoreThenGems = this.totalCash > this.totalGems;

                    if (IsMoreThenGems)
                    {
                        continue;
                    }

                    bag.AddPrecious(precious);
                }
            }
        }
    }
}
