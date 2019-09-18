using Military_Elite.Contracts;
using Military_Elite.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Military_Elite.Core
{
    public class Engine
    {
        private readonly List<IPrivate> privates;

        public Engine()
        {
            privates = new List<IPrivate>();
        }

        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] args = input.Split();

                string soldierType = args[0];
                string id = args[1];
                string firstName = args[2];
                string lastName = args[3];

                try
                {
                    if (soldierType == "Private")
                    {
                        decimal salary = decimal.Parse(args[4]);

                        IPrivate soldier = new Private(id, firstName, lastName, salary);

                        privates.Add(soldier);
                    }
                    else if (soldierType == "Spy")
                    {
                        int codeNumber = int.Parse(args[4]);

                        ISpy soldier = new Spy(id, firstName, lastName, codeNumber);
                    }
                    else if (soldierType == "LieutenantGeneral")
                    {
                        decimal salary = decimal.Parse(args[4]);

                        var privatesCollection = args.Skip(5).ToList();

                        ILieutenantGeneral soldier = new LieutenantGeneral(id, firstName, lastName, salary, privatesCollection);
                        
                    }

                   
                }
                catch (Exception)
                {

                    throw;
                }

                input = Console.ReadLine();
            }
        }
    }
}
