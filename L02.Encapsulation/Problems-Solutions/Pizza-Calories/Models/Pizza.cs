using System;

namespace Pizza_Calories.Models
{
    public class Pizza
    {
        private const int MIN_VALUE = 1;
        private const int MAX_VALUE = 15;
        private string name;

        public Pizza(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 15)
                {
                    throw new ArgumentException($"Pizza name should be between {MIN_VALUE} and {MAX_VALUE} symbols.");
                }
                this.name = value;
            }
        }
    }
}
