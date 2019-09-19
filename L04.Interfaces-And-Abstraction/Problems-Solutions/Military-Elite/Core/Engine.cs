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
        private readonly List<ISoldier> soldiers;

        public Engine()
        {
           this.privates = new List<IPrivate>();
           this.soldiers = new List<ISoldier>();
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

                        this.privates.Add(soldier);
                        this.soldiers.Add(soldier);
                    }
                    else if (soldierType == "Spy")
                    {
                        int codeNumber = int.Parse(args[4]);

                        ISpy soldier = new Spy(id, firstName, lastName, codeNumber);

                        this.soldiers.Add(soldier);

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

                        this.soldiers.Add(soldier);
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

                        this.soldiers.Add(soldier);
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
                            string state = missions[i + 1];
                            try
                            {
                                IMission currentMission = new Mission(name, state);
                                soldier.AddMission(currentMission);
                            }
                            catch (Exception)
                            {
                                
                            }
                        }

                        this.soldiers.Add(soldier);
                    }
                }
                catch (Exception)
                {

                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(Environment.NewLine, this.soldiers));
        }
    }
}
