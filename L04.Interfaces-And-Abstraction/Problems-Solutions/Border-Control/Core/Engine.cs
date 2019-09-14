using Border_Control.Contracts;
using Border_Control.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Border_Control.Core
{
    public class Engine
    {
        private IRegisterable habitant;
        private readonly List<IRegisterable> registationList;

        public Engine()
        {
            registationList = new List<IRegisterable>();
        }

        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] args = input.Split();

                if (args.Length == 3)
                {
                    habitant = new Citizen(args[0], int.Parse(args[1]), args[2]);
                }
                else if (args.Length == 2)
                {
                    habitant = new Robot(args[0], args[1]);
                }

                registationList.Add(habitant);

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            List<IRegisterable> detanedIds = this.registationList.Where(x => x.Id.EndsWith(input)).ToList();

            Console.WriteLine(string.Join(Environment.NewLine, detanedIds.Select(s => s.Id)));
        }
    }
}
