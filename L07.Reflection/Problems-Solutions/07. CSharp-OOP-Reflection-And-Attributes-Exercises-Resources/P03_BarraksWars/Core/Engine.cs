namespace _03BarracksFactory.Core
{
    using System;
    using Contracts;

    class Engine : IRunnable
    {
        private IRepository unitRepository;
        private IUnitFactory unitFactory;

        public Engine(IRepository unitRepository, IUnitFactory unitFactory)
        {
            this.unitRepository = unitRepository;
            this.unitFactory = unitFactory;
        }
        
        public void Run()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    string[] data = input.Split();
                    string commandName = data[0];
                    string result = InterpredCommand(data, commandName);
                    Console.WriteLine(result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        // TODO: refactor for Problem 4 - with Reflection
        private string InterpredCommand(string[] data, string commandName)
        {
            string result = string.Empty;

            switch (commandName)
            {
                case "add":
                    result = this.AddUnitCommand(data);
                    break;
                case "report":
                    result = this.ReportCommand(data);
                    break;
                case "retire":
                    result = this.RetireCommand(data);
                    break;
                case "fight":
                    Environment.Exit(0);
                    break;
                default:
                    throw new InvalidOperationException("Invalid command!");
            }

            return result;
        }

        private string RetireCommand(string[] data)
        {
            string unitType = data[1];
            this.unitRepository.RemoveUnit(unitType);

            return $"{unitType} retired!";

        }

        private string ReportCommand(string[] data)
        {
            string output = this.unitRepository.Statistics;

            return output;
        }


        private string AddUnitCommand(string[] data)
        {
            string unitType = data[1];
            IUnit unitToAdd = this.unitFactory.CreateUnit(unitType);
            this.unitRepository.AddUnit(unitToAdd);

            return $"{unitType} added!";
        }
    }
}
