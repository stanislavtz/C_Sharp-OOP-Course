﻿using System;
using System.Collections.Generic;
using System.Text;
using Wild_Farm.Contracts;
using Wild_Farm.Models.Foods;

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
            double foodModifier = FOOD_MODIFIER;
            List<string> foods = foodCollection;

            if (!foods.Contains(food.GetType().Name))
            {
                throw new InvalidOperationException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }

            this.Weight += food.Quantity * foodModifier;

            return this.Weight;
        }
    }
}
