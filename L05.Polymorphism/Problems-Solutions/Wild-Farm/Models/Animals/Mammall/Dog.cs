using System;
using System.Collections.Generic;
using Wild_Farm.Contracts;

namespace Wild_Farm.Models.Animals.Mammall
{
    public class Dog : Mammal

    {
        private const double FOOD_MODIFIER = 0.40;
        private readonly List<string> foodCollection = new List<string>
        {
            "Meat"
        };

        public Dog(string name, double weight, int foodEaten, string livingRegion)
            : base(name, weight, foodEaten, livingRegion)
        {
        }

        public override string AskFood()
        {
            return "Woof!";
        }


        public override double EatFood(IFood food)
        {
            return FoodEatenValidation(food, FOOD_MODIFIER, foodCollection);
        }

        public override string ToString()
        {
            return $"{base.ToString()} {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
