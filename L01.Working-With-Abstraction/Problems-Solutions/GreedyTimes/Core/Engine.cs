using System;
using System.Linq;

using P05_GreedyTimes.Models;
using P05_GreedyTimes.Factories;

namespace P05_GreedyTimes.Core
{
    public class Engine
    {
        private readonly PreciousFactory factory = new PreciousFactory();

        private IPrecious precious;

        public void Run()
        {
            int totalGoldQtty = 0;
            int totalGemQtty = 0;
            int totalCashQtty = 0;

            int bagCapacity = int.Parse(Console.ReadLine());

            string[] caseArgs = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Bag bag = new Bag(bagCapacity);

            for (int i = 0; i < caseArgs.Length; i += 2)
            {
                string typeOfPrecious = caseArgs[i];
                int preciousQuantity = int.Parse(caseArgs[i + 1]);

                this.precious = factory.CreatePrecious(typeOfPrecious, preciousQuantity);

                if (typeOfPrecious.ToLower() == "gold")
                {
                    bool canAddGold = totalGoldQtty + precious.Quantity <= bagCapacity;

                    if (canAddGold)
                    {
                        bag.AddGold(precious);
                        bagCapacity -= precious.Quantity;
                        totalGoldQtty = bag.GoldCollection.Sum(s => s.Quantity);
                    }
                }
                else if (typeOfPrecious.ToLower().EndsWith("gem"))
                {
                    bool canAddGem = totalGemQtty + precious.Quantity <= totalGoldQtty;

                    if (canAddGem)
                    {
                        bag.AddGem(precious);
                        bagCapacity -= precious.Quantity;
                        totalGemQtty = bag.GemCollection.Sum(s => s.Quantity);
                    }
                }
                else if(typeOfPrecious.Length == 3)
                {
                    bool canAddCash = totalCashQtty + precious.Quantity <= totalGemQtty;

                    if (canAddCash)
                    {
                        bag.AddCash(precious);
                        bagCapacity -= precious.Quantity;
                        totalCashQtty = bag.CashCollection.Sum(s => s.Quantity);
                    }
                }
            }

            PrintGoldInfo(totalGoldQtty);
            PrintGemInfo(totalGemQtty, bag);
            PrintCashInfo(totalCashQtty, bag);
        }

        private static void PrintCashInfo(int totalCashQtty, Bag bag)
        {
            if (totalCashQtty > 0)
            {
                Console.WriteLine($"<Cash> ${totalCashQtty}");
                foreach (var item in bag.CashCollection.OrderByDescending(b => b.PreciousType).ThenBy(b => b.Quantity))
                {
                    Console.WriteLine($"##{item.PreciousType.ToUpper()} - {item.Quantity}");
                }
            }
        }

        private static void PrintGemInfo(int totalGemQtty, Bag bag)
        {
            if (totalGemQtty > 0)
            {
                Console.WriteLine($"<Gem> ${totalGemQtty}");
                foreach (var item in bag.GemCollection.OrderByDescending(b => b.PreciousType).ThenBy(b => b.Quantity))
                {
                    Console.WriteLine($"##{item.PreciousType} - {item.Quantity}");
                }
            }
        }

        private static void PrintGoldInfo(int totalGoldQtty)
        {
            if (totalGoldQtty > 0)
            {
                Console.WriteLine($"<Gold> ${totalGoldQtty}");
                Console.WriteLine($"##Gold - {totalGoldQtty}");
            }
        }
    }
}
