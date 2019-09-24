using System;
using System.Collections.Generic;
using Wild_Farm.Contracts;

namespace Wild_Farm.Models.Animals
{
    public abstract class Animal : IAnimal
    {
        private const double FOOD_MODIFIER = 1;
        private List<string> foodCollection = new List<string>
        {
            "Fruit",
            "Meat",
            "Seeds",
            "Vegetable"
        };

        public Animal(string name, double weight, int foodEaten)
        {
            this.Name = name;
            this.Weight = weight;
            this.FoodEaten = foodEaten;
        }

        public string Name { get; private set; }

        public double Weight { get; protected set; }

        public int FoodEaten { get;  set; }

        public abstract string AskFood();

        public virtual double EatFood(IFood food)
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
            return $"{this.GetType().Name} [{this.Name},";
        }
    }
}
