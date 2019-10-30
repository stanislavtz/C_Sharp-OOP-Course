using System;
using System.Linq;
using System.Reflection;

using CommandPattern.Core.Contracts;

namespace CommandPattern.Core.Models
{
    public class CommandInterpreter : ICommandInterpreter
    {
        private const string COMMAND_POSTFIX = "Command";

        public string Read(string inputLine)
        {
            string[] tokens = inputLine
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string commandName = tokens[0] + COMMAND_POSTFIX;

            string[] commandArgs = tokens
                .Skip(1)
                .ToArray();

            Assembly assembly = Assembly
                .GetExecutingAssembly();

            Type currentCommandType = assembly
                .GetTypes()
                .FirstOrDefault(x => x.Name == commandName);

            if (currentCommandType == null)
            {
                throw new ArgumentException("Invalid command!");
            }

            var command = (ICommand)Activator
                .CreateInstance(currentCommandType, new object[] { });

            return command.Execute(commandArgs);
        }
    }
}
