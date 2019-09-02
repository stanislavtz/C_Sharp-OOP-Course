using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Calories.Models
{
    public class Dough
    {
        private const double MinWeight = 1;
        private const double MaxWeight = 200;

        private readonly Dictionary<string, double> mainDoughTypes = new Dictionary<string, double>
        {
            {"white", 1.5},
            {"wholegrain", 1.0}
        };

        private readonly Dictionary<string, double> additionalDoughTypes = new Dictionary<string, double>
        {
            {"chewy", 1.1},
            {"homemade", 1.0},
            {"crispy", 0.9}
        };

        private double weight;
        private string mainType;
        private string additionalType;

        public Dough(string mainType, string additionalType, double weight)
        {
            this.Weight = weight;
            this.MainType = mainType;
            this.AdditionalType = additionalType;
        }

        public double Weight
        {
            get => this.weight;
            private set
            {
                if (value < MinWeight || value > MaxWeight)
                {
                    throw new ArgumentException($"Dough weight should be in the range [{MinWeight}..{MaxWeight}].");
                }

                this.weight = value;
            }
        }

        public string MainType
        {
            get => this.mainType;
            private set
            {
                DouhtTypeValidator(value.ToLower(), mainDoughTypes);
                this.mainType = value;
            }
        }

        public string AdditionalType
        {
            get => this.additionalType;
            private set
            {
                DouhtTypeValidator(value.ToLower(), additionalDoughTypes);
                this.additionalType = value;
            }
        }

        public double ClculateCalories()
        {
            return 2 * this.Weight * this.mainDoughTypes[MainType.ToLower()] * this.additionalDoughTypes[AdditionalType.ToLower()];
        }

        private void DouhtTypeValidator(string value, Dictionary<string, double> doughtType)
        {
            if (!doughtType.ContainsKey(value))
            {
                throw new ArgumentException("Invalid type of dough.");
            }
        }
    }
}
