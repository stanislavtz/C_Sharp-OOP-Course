using System;
using System.Collections.Generic;
using Wild_Farm.Contracts;

namespace Wild_Farm.Models.Animals
{
    public abstract class Animal : IAnimal
    {
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

        public abstract double EatFood(IFood food);

        protected double FoodEatenValidation(IFood food, double foodModifier, List<string> foods)
        {
            var animalType = this.GetType().Name;
            var foodType = food.GetType().Name;

            if (!foods.Contains(foodType))
            {
                throw new InvalidOperationException($"{animalType} does not eat {foodType}!");
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
