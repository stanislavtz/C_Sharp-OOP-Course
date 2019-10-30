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
                try
                {
                    string inputLine = Console.ReadLine();

                    string result = this.commandInterpreter.Read(inputLine);

                    Console.WriteLine(result);
                }
                catch (ArgumentNullException anx)
                {
                    Console.WriteLine(anx.Message);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
