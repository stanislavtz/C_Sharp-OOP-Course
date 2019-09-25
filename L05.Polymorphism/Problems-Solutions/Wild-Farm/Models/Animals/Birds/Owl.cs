using System.Collections.Generic;
using Wild_Farm.Contracts;

namespace Wild_Farm.Models.Animals.Birds
{
    public class Owl : Bird
    {
        private const double FOOD_MODIFIER = 0.25;
        private readonly List<string> foodCollection = new List<string>
        {
            "Meat"
        };

        public Owl(string name, double weight, int foodEaten, double wingSize) 
            : base(name, weight, foodEaten, wingSize)
        {
        }

        public override string AskFood()
        {
            return "Hoot Hoot";
        }

        public override double EatFood(IFood food)
        {
            return FoodEatenValidation(food, FOOD_MODIFIER, foodCollection);
        }
    }
}
