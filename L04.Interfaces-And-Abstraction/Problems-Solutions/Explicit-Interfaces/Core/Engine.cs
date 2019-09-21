using System;
using Explicit_Interfaces.Main;
using System.Collections.Generic;
using Explicit_Interfaces.Contracts;

namespace Explicit_Interfaces.Core
{
    public class Engine
    {
        private readonly List<ICitizen> citizens;

        public Engine()
        {
            this.citizens = new List<ICitizen>();
        }

        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] args = input.Split();

                string fullName = $"{args[0]} {args[1]}";
                string country = args[2];
                int age = int.Parse(args[3]);

                ICitizen citizen = new Citizen(fullName, country, age);

                citizens.Add(citizen);

                input = Console.ReadLine();
            }

            foreach (var citizen  in citizens)
            {
                Console.WriteLine();
                Console.WriteLine(citizen);
            }
        }
    }
}
