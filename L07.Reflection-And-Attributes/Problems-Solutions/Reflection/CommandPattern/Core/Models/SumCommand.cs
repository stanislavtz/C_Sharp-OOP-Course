using System;
using System.Linq;
using CommandPattern.Core.Contracts;

namespace CommandPattern.Core.Models
{
    public class SumCommand : ICommand
    {
        public string Execute(string[] args)
        {
            foreach (var item in args)
            {
                if (item.Any(x => !char.IsDigit(x)))
                {
                    throw new ArgumentException("The arguments should be numbers!");
                }
            }

            int[] array = args
                .Select(int.Parse)
                .ToArray();

            int sum = array.Sum();

            return $"Sum : {sum}";
        }
    }
}
