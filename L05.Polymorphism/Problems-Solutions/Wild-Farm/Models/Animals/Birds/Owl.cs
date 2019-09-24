using System;
using System.Collections.Generic;
using Wild_Farm.Models.Foods;

namespace Wild_Farm.Models.Animals.Birds
{
    public class Owl : Bird
    {
        private const double FOOD_MODIFICATOR = 0.25;

        private readonly List<string> preferedFood = new List<string>
        {
            "Meat"
        };

        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        public override void AddFood(string foodType)
        {
            preferedFood.Add(foodType);
        }

        public override string AskFood()
        {
            return "Hoot Hoot";
        }

        public override double EatFood(Food food)
        {
            if (!preferedFood.Contains(nameof(food)))
            {
                throw new InvalidOperationException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }

            this.Weight += this.FoodEaten * FOOD_MODIFICATOR;

            return this.Weight;
        }
    }
}
