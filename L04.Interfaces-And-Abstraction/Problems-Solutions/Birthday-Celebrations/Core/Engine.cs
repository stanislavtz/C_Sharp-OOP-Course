using Birthday_Celebrations.Contracts;
using Birthday_Celebrations.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Birthday_Celebrations.Core
{
    public class Engine
    {
        private IBirthable birthDateCelebrator;
        private readonly List<IBirthable> celebrators;

        public Engine()
        {
            celebrators = new List<IBirthable>();
        }

        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string firstWord = input.Split()[0];

                string[] args = input.Split().Skip(1).ToArray();

                if (firstWord == "Citizen")
                {
                    birthDateCelebrator = new Citizen(args[0], int.Parse(args[1]), args[2], args[3]);
                }
                else if (firstWord == "Pet")
                {
                    birthDateCelebrator = new Pet(args[0], args[1]);
                }
                else
                {
                    birthDateCelebrator = null;
                }

                if (birthDateCelebrator != null)
                {
                    celebrators.Add(birthDateCelebrator);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            List<IBirthable> filteredCelebrators = this.celebrators.Where(x => x.BirthDate.EndsWith(input)).ToList();

            if (filteredCelebrators.Count != 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, filteredCelebrators.Select(s => s.BirthDate)));
            }
        }
    }
}
