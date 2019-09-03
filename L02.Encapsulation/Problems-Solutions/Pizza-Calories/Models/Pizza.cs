using System;
using System.Linq;
using System.Collections.Generic;

namespace Pizza_Calories.Models
{
    public class Pizza
    {
        private const int MIN_NAME_LENGTH = 1;
        private const int MAX_NAME_LENGTH = 15;

        private const int MIN_TOPPINGS = 0;
        private const int MAX_TOPPINGS = 10;

        private string name;
        private readonly Dough dough;
        private readonly List<Topping> toppings;

        public Pizza(string name, Dough dough)
        {
            this.Name = name;
            this.dough = dough;
            this.toppings = new List<Topping>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException($"Pizza name should be between {MIN_NAME_LENGTH} and {MAX_NAME_LENGTH} symbols.");
                }

                this.name = value;
            }
        }

        public int ToppingsCount() => this.toppings.Count(); 

        public double GetTotalCalories() =>
            this.dough.ClculateCalories() + this.toppings.Sum(x => x.CalculateCalories());

        public void AddTopping(Topping topping)
        {
            if (this.ToppingsCount() > 10)
            {
                throw new ArgumentException($"Number of toppings should be in range [{MIN_TOPPINGS}..{MAX_TOPPINGS}].");
            }

            this.toppings.Add(topping);
        }
    }
}
