﻿using System.Collections.Generic;
using Wild_Farm.Contracts;

namespace Wild_Farm.Models.Animals.Birds
{
    public class Hen : Bird
    {
        private const double FOOD_MODIFIER = 0.35;
        private readonly List<string> foodCollection = new List<string>
        {
            "Fruit",
            "Meat",
            "Seeds",
            "Vegetable"
        };

        public Hen(string name, double weight, int foodEaten, double wingSize)
            : base(name, weight, foodEaten, wingSize)
        {
        }

        public override string AskFood()
        {
            return "Cluck";
        }

        public override double EatFood(IFood food)
        {
            return GainWeight(food, FOOD_MODIFIER, foodCollection);
        }
    }
}
