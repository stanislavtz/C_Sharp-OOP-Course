using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_GreedyTimes
{

    public class StartUp
    {
        static void Main(string[] args)
        {
            long bagCapacity = long.Parse(Console.ReadLine());

            string[] caseContent = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var bag = new Dictionary<string, Dictionary<string, long>>();

            long gold = 0;
            long gems = 0;
            long cash = 0;

            for (int i = 0; i < caseContent.Length; i += 2)
            {
                string itemType = caseContent[i];
                long itemQuantity = long.Parse(caseContent[i + 1]);

                string typeOfItem = string.Empty;

                if (itemType.Length == 3)
                {
                    typeOfItem = "Cash";
                }
                else if (itemType.ToLower().EndsWith("gem"))
                {
                    typeOfItem = "Gem";
                }
                else if (itemType.ToLower() == "gold")
                {
                    typeOfItem = "Gold";
                }

                if (typeOfItem == "")
                {
                    continue;
                }
                else if (bagCapacity < bag.Values.Select(x => x.Values.Sum()).Sum() + itemQuantity)
                {
                    continue;
                }

                switch (typeOfItem)
                {
                    case "Gem":
                        if (!bag.ContainsKey(typeOfItem))
                        {
                            if (bag.ContainsKey("Gold"))
                            {
                                if (itemQuantity > bag["Gold"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (bag[typeOfItem].Values.Sum() + itemQuantity > bag["Gold"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                    case "Cash":
                        if (!bag.ContainsKey(typeOfItem))
                        {
                            if (bag.ContainsKey("Gem"))
                            {
                                if (itemQuantity > bag["Gem"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (bag[typeOfItem].Values.Sum() + itemQuantity > bag["Gem"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                }

                if (!bag.ContainsKey(typeOfItem))
                {
                    bag[typeOfItem] = new Dictionary<string, long>();
                }

                if (!bag[typeOfItem].ContainsKey(itemType))
                {
                    bag[typeOfItem][itemType] = 0;
                }

                bag[typeOfItem][itemType] += itemQuantity;
                if (typeOfItem == "Gold")
                {
                    gold += itemQuantity;
                }
                else if (typeOfItem == "Gem")
                {
                    gems += itemQuantity;
                }
                else if (typeOfItem == "Cash")
                {
                    cash += itemQuantity;
                }
            }

            foreach (var x in bag)
            {
                Console.WriteLine($"<{x.Key}> ${x.Value.Values.Sum()}");
                foreach (var item2 in x.Value.OrderByDescending(y => y.Key).ThenBy(y => y.Value))
                {
                    Console.WriteLine($"##{item2.Key} - {item2.Value}");
                }
            }
        }
    }
}