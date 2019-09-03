using System;
using System.Collections.Generic;

namespace Pizza_Calories.Models
{
    public class Topping
    {
        private const int baseCalories = 2;
        private const double MinWeight = 1;
        private const double MaxWeight = 50;

        private string toppingType;
        private double weight;
        private readonly Dictionary<string, double> toppingTypes;

        public Topping(string type, double weight)
        {
            this.toppingTypes = new Dictionary<string, double>();
            this.SeedToppings();

            this.ToppingType = type;
            this.Weight = weight;
        }

        public double Weight
        {
            get => this.weight;
            private set
            {
                if (value < 1 || value > 50)
                {
                    throw new ArgumentException($"{this.ToppingType} weight should be in the range [{MinWeight}..{MaxWeight}].");
                }
                this.weight = value;
            }
        }

        public string ToppingType
        {
            get => this.toppingType;
            private set
            {
                if (!toppingTypes.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                this.toppingType = value;
            }
        }

        public double CalculateCalories()
        {
            return baseCalories 
                * this.Weight 
                * this.toppingTypes[this.ToppingType.ToLower()];
        }

        private void SeedToppings()
        {
            this.toppingTypes.Add("meat", 1.2);
            this.toppingTypes.Add("veggies", 0.8);
            this.toppingTypes.Add("cheese", 1.1);
            this.toppingTypes.Add("sauce", 0.9);
        }
    }
}
