using System;
using CommandPattern.Core.Contracts;

namespace CommandPattern.Core.Models
{
    public class Engine : IEngine
    {
        private readonly ICommandInterpreter commandInterpreter;

        public Engine(ICommandInterpreter commandInterpreter)
        {
            this.commandInterpreter = commandInterpreter;
        }

        public void Run()
        {
            while (true)
            {
                string inputLine = Console.ReadLine();

                try
                {
                    Console.WriteLine(this.commandInterpreter.Read(inputLine));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}
