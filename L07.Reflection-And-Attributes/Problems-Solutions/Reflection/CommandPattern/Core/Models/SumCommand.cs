using System.Linq;
using CommandPattern.Core.Contracts;

namespace CommandPattern.Core.Models
{
    public class SumCommand : ICommand
    {
        public string Execute(string[] args)
        {
            int[] array = args
                .Select(int.Parse)
                .ToArray();

            int sum = array.Sum();

            return $"Sum : {sum}";
        }
    }
}
