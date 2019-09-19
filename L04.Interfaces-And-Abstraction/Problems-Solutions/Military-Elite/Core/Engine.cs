using Military_Elite.Contracts;
using Military_Elite.Contracts.SpecialForces;
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

                        string[] ids = args.Skip(5).ToArray();

                        ILieutenantGeneral soldier = new LieutenantGeneral(id, firstName, lastName, salary);

                        foreach (var item in ids)
                        {
                            var currentPrivate = privates.First(p => p.Id == item);
                            soldier.AddSoldier(currentPrivate);
                        }
                    }
                    else if (soldierType == "Engineer")
                    {
                        decimal salary = decimal.Parse(args[4]);
                        string corps = args[5];

                        string[] repairs = args.Skip(6).ToArray();

                        IEngineer soldier = new Engineer(id, firstName, lastName, salary, corps);

                        for (int i = 0; i < repairs.Length; i += 2)
                        {
                            string partName = repairs[i];
                            int hoursWorked = int.Parse(repairs[i + 1]);

                            IRepair currentRepair = new Repair(partName, hoursWorked);

                            soldier.AddRepair(currentRepair);
                        }
                    }
                    else if (soldierType == "Commando")
                    {
                        decimal salary = decimal.Parse(args[4]);
                        string corps = args[5];

                        string[] missions = args.Skip(6).ToArray();

                        ICommando soldier = new Commando(id, firstName, lastName, salary, corps);

                        for (int i = 0; i < missions.Length; i += 2)
                        {
                            string name = missions[i];
                            string state = missions[i = 1];

                            IMission currentMission = new Mission(name, state);

                            soldier.AddMission(currentMission);
                        }
                    }
                }
                catch (Exception)
                {

                }

                input = Console.ReadLine();
            }
        }
    }
}
