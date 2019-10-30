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
                    throw new ArgumentException("Arguments should be numbers!", item);
                }

            }

            int[] numbers = args
                .Select(int.Parse)
                .ToArray();

            int sum = numbers.Sum();

            string result = $"The sum is: {sum}";

            return result;
        }
    }
}
