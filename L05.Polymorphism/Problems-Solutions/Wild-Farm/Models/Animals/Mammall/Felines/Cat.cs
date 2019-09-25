using System.Collections.Generic;
using Wild_Farm.Contracts;

namespace Wild_Farm.Models.Animals.Mammall.Felines
{
    public class Cat : Feline
    {
        private const double FOOD_MODIFIER = 0.30;

        private readonly List<string> foodCollection = new List<string>()
        {
            "Vegetable",
            "Meat"
        };

        public Cat(string name, double weight, int foodEaten, string livingRegion, string breed)
            : base(name, weight, foodEaten, livingRegion, breed)
        {
        }

       
        public override string AskFood()
        {
            return "Meow";
        }

        public override double EatFood(IFood food)
        {
            return GainWeight(food, FOOD_MODIFIER, foodCollection);
        }
    }
}
