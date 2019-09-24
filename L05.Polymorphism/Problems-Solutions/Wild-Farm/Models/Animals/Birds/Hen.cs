using System;
using System.Collections.Generic;
using Wild_Farm.Models.Foods;

namespace Wild_Farm.Models.Animals.Birds
{
    public class Hen : Bird
    {
        private const double FOOD_MODIFIER= 0.35;

        private readonly List<string> preferedFood = new List<string>()
        {
            "Fruit",
            "Meat",
            "Seeds",
            "Vegetable"
        };

        public Hen(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        public override void AddFood(string foodType)
        {
            preferedFood.Add(foodType);
        }

        public override string AskFood()
        {
            return "Cluck";
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
