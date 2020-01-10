using System;
using System.Linq;
using System.Reflection;
using Wild_Farm.Contracts;
using Wild_Farm.Exceptions;

namespace Wild_Farm
{
    public class FoodFactory
    {
        public IFood ProduceFood(params string[] foodArgs)
        {
            string foodType = foodArgs[0];
            int quantity = int.Parse(foodArgs[1]);

            Type type = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name == foodType);

            IFood food = (IFood)Activator.CreateInstance(type, new object[] { quantity });

            if (food == null)
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidFoodException);
            }

            return food;
        }
    }
}
