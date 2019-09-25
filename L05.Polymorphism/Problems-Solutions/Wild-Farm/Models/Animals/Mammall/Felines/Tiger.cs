using System;
using System.Collections.Generic;
using System.Text;
using Wild_Farm.Contracts;
using Wild_Farm.Models.Foods;

namespace Wild_Farm.Models.Animals.Mammall.Felines
{
    public class Tiger : Feline
    {
        private const double FOOD_MODIFIER = 1;

        private readonly List<string> foodCollection = new List<string>()
        {
            "Meat"
        };

        public Tiger(string name, double weight, int foodEaten, string livingRegion, string breed)
            : base(name, weight, foodEaten, livingRegion, breed)
        {
        }


        public override string AskFood()
        {
            return "ROAR!!!";
        }

        public override double EatFood(IFood food)
        {
            return FoodEatenValidation(food, FOOD_MODIFIER, foodCollection);
        }
    }
}
