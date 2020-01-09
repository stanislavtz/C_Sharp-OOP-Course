using System;
using Wild_Farm.Contracts;
using Wild_Farm.Exceptions;
using Wild_Farm.Models.Foods;

namespace Wild_Farm
{
    public class FoodFactory
    {
        public IFood CreatFood(params string[] foodArgs)
        {
            string type = foodArgs[0];
            int quantity = int.Parse(foodArgs[1]);

            IFood food;

            if (type == "Fruit")
            {
                food =  new Fruit(quantity);
            }
            else if (type == "Meat")
            {
                food = new Meat(quantity);
            }
            else if (type == "Seeds")
            {
                food = new Seeds(quantity);
            }
            else if (type == "Vegetable")
            {
                food = new Vegetable(quantity);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidFoodException);
            }

            return food;
        }
    }
}
