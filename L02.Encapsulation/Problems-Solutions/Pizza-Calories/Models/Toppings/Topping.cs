using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Calories.Models
{
    public class Topping
    {
        private const double MinWeight = 1;
        private const double MaxWeight = 50;

        private string toppingType;
        private double weight;
        private readonly Dictionary<string, double> toppingTypes = new Dictionary<string, double>
        {
            {"meat", 1.2},
            {"veggies", 0.8},
            {"cheese", 1.1},
            {"sauce", 0.9},
        };

        public Topping(string type, double weight)
        {
            this.ToppingType = type;
            this.Weight = weight;
        }

        public double Weight
        {
            get => this.weight;
            set
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
            return 2 * this.Weight * this.toppingTypes[ToppingType.ToLower()];
        }
    }
}
