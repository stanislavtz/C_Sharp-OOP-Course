using Military_Elite.Contracts;
using Military_Elite.Contracts.SpecialForces;
using Military_Elite.Exceptions;
using Military_Elite.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Military_Elite.Core
{
    public class Engine
    {
        private readonly List<ISoldier> army;

        public Engine()
        {
           this.army = new List<ISoldier>();
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
                    ISoldier soldier = null;

                    if (soldierType == "Private")
                    {
                        decimal salary = decimal.Parse(args[4]);

                        soldier = new Private(id, firstName, lastName, salary);
                    }
                    else if (soldierType == "Spy")
                    {
                        int codeNumber = int.Parse(args[4]);

                        soldier = new Spy(id, firstName, lastName, codeNumber);
                    }
                    else if (soldierType == "LieutenantGeneral")
                    {
                        decimal salary = decimal.Parse(args[4]);

                        string[] ids = args.Skip(5).ToArray();

                        soldier = new LieutenantGeneral(id, firstName, lastName, salary);

                        foreach (var item in ids)
                        {
                            var currentPrivate = army.First(p => p.Id == item);

                            ILieutenantGeneral ltg = soldier as ILieutenantGeneral;

                            ltg.AddSoldier((IPrivate)currentPrivate);
                        }
                    }
                    else if (soldierType == "Engineer")
                    {
                        decimal salary = decimal.Parse(args[4]);
                        string corps = args[5];

                        string[] repairsInfo = args.Skip(6).ToArray();

                        soldier = new Engineer(id, firstName, lastName, salary, corps);

                        for (int i = 0; i < repairsInfo.Length; i += 2)
                        {
                            string partName = repairsInfo[i];
                            int hoursWorked = int.Parse(repairsInfo[i + 1]);

                            IRepair currentRepair = new Repair(partName, hoursWorked);

                            IEngineer engineer = soldier as IEngineer;

                            engineer.AddRepair(currentRepair);
                        }
                    }
                    else if (soldierType == "Commando")
                    {
                        decimal salary = decimal.Parse(args[4]);
                        string corps = args[5];

                        string[] missions = args.Skip(6).ToArray();

                        soldier = new Commando(id, firstName, lastName, salary, corps);

                        for (int i = 0; i < missions.Length; i += 2)
                        {
                            string name = missions[i];
                            string state = missions[i + 1];
                            try
                            {
                                IMission currentMission = new Mission(name, state);

                                ICommando commando = soldier as ICommando;

                                commando.AddMission(currentMission);
                            }
                            catch (InvalidMissionStatmentException imsex)
                            {
                               Console.WriteLine(imsex.Message);
                            }
                        }
                    }

                    if (soldier != null)
                    {
                        this.army.Add(soldier);
                    }
                }
                catch (InvalidCorpsException icex)
                {
                    Console.WriteLine(icex.Message); ;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(Environment.NewLine, this.army));
        }
    }
}
