using System;
using System.Collections.Generic;
using Wild_Farm.Models.Foods;

namespace Wild_Farm.Models.Animals.Mammall
{
    public class Mouse : Mammal
    {
        private const double FOOD_MODIFIER = 0.10;

        private readonly List<string> preferedFood = new List<string>()
        {
            "Fruit",
            "Vegetable"
        };

        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override void AddFood(string foodType)
        {
            preferedFood.Add(foodType);
        }

        public override string AskFood()
        {
            return "Squeak";
        }

        public override double EatFood(Food food)
        {

            string foodName = food.GetType().Name;

            if (!preferedFood.Contains(foodName))
            {
                throw new InvalidOperationException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }

            this.Weight += (this.FoodEaten * FOOD_MODIFIER);

            return this.Weight;
        }
    }
}
