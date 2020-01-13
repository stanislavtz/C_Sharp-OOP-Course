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
            string[] inputArgs = inputLine
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            if (inputArgs.Length == 0)
            {
                throw new IndexOutOfRangeException("Invalid input!");
            }

            string commandName = inputArgs[0] + COMMAND_POSTFIX;

            Assembly assembly = Assembly.GetCallingAssembly();

            Type currentCommandType = assembly
                .GetTypes()
                .FirstOrDefault(x => x.Name.ToLower() == commandName.ToLower());

            if (currentCommandType == null)
            {
                throw new ArgumentException("Invalid type!");
            }
            
            string[] commandArgs = inputArgs
                .Skip(1)
                .ToArray();

            var command = (ICommand)Activator
                .CreateInstance(currentCommandType);

            return command.Execute(commandArgs);
        }
    }
}
