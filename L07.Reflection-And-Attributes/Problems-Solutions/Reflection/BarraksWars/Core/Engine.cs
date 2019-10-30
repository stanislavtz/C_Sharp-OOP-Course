namespace _03BarracksFactory.Core
{
    using System;
    using System.Linq;
    using System.Reflection;

    using Contracts;
    using P03_BarraksWars.Core.Commands;

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

        private string InterpredCommand(string[] data, string commandName)
        {
            Type type = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name.ToLower() == commandName + "command");

            var instance = Activator.CreateInstance(type, new object[] { data, this.unitFactory, this.unitRepository });

            var method = type.GetMethod("Execute");

            try
            {
                var result = method.Invoke(instance, null) as string;
             
                return result;
            }
            catch (Exception ex)
            {
                return ex.InnerException.Message;
            }
        }
    }
}
