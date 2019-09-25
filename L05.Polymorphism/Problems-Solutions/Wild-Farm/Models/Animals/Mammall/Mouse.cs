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
            return GainWeight(food, FOOD_MODIFIER, foodCollection);
        }

        public override string ToString()
        {
            return $"{base.ToString()} {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
