using Food_Shortage.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Food_Shortage.Core
{
    public class Engine
    {
        private Person person;
        private readonly List<Person> people;

        public Engine()
        {
            this.people = new List<Person>();
        }

        public void Run()
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string input = Console.ReadLine();
                string[] args = input.Split();

                string name = args[0];
                int age = int.Parse(args[1]);

                if (args.Length == 4)
                {
                    string id = args[2];
                    string birthDate = args[3];

                    this.person = new Citizen(name, age, id, birthDate);
                }
                else if (args.Length == 3)
                {
                    string group = args[2];

                    this.person = new Rebel(name, age, group);
                }

                this.people.Add(this.person);
            }

            string inputName = Console.ReadLine();

            while (inputName != "End")
            {
                this.person = this.people.FirstOrDefault(p => p.Name == inputName);

                if (person != null)
                {
                    this.person.FoodCounter();
                }

                inputName = Console.ReadLine();
            }

            int totalBoughtFood = people.Sum(s => s.BoughtFood);

            Console.WriteLine(totalBoughtFood);
        }
    }
}
