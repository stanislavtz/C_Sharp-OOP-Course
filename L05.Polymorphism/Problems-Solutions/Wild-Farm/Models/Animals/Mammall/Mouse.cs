using System;
using System.Collections.Generic;
using Wild_Farm.Contracts;

namespace Wild_Farm.Models.Animals.Mammall
{
    public class Mouse : Mammal
    {
        private const double FOOD_MODIFIER = 0.10;

        private readonly List<string> foodCollection = new List<string>()
        {
            "Fruit",
            "Vegetable"
        };

        public Mouse(string name, double weight, int foodEaten, string livingRegion) 
            : base(name, weight, foodEaten, livingRegion)
        {
        }

        public override string AskFood()
        {
            return "Squeak";
        }

        public override double EatFood(IFood food)
        {
            double foodModifier = FOOD_MODIFIER;
            List<string> foods = foodCollection;

            if (!foods.Contains(food.GetType().Name))
            {
                throw new InvalidOperationException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }

            this.Weight += food.Quantity * foodModifier;

            return this.Weight;
        }

        public override string ToString()
        {
            return $"{base.ToString()} {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
