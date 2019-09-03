using System;
using System.Collections.Generic;

namespace Pizza_Calories.Models
{
    public class Dough
    {
        private const int BaseCalories = 2;
        private const double MinWeight = 1;
        private const double MaxWeight = 200;

        private string flourType;
        private string backingTechnique;
        private double weight;

        private readonly Dictionary<string, double> currentFlourTypes;
        private readonly Dictionary<string, double> currentBackingTechniques;

        public Dough(string type, string technique, double weight)
        {
            this.currentFlourTypes = new Dictionary<string, double>();
            this.currentBackingTechniques = new Dictionary<string, double>();
            this.SeedFlourTypes();
            this.SeedBackingTechniques();

            this.FlourType = type;
            this.BackingTechnique = technique;
            this.Weight = weight;
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

        public string FlourType
        {
            get => this.flourType;
            private set
            {
                DouhtTypeValidator(value.ToLower(), currentFlourTypes);
                this.flourType = value;
            }
        }

        public string BackingTechnique
        {
            get => this.backingTechnique;
            private set
            {
                DouhtTypeValidator(value.ToLower(), currentBackingTechniques);
                this.backingTechnique = value;
            }
        }

        public double ClculateCalories()
        {
            return BaseCalories 
                * this.Weight 
                * this.currentFlourTypes[this.FlourType.ToLower()] 
                * this.currentBackingTechniques[this.BackingTechnique.ToLower()];
        }

        private void SeedFlourTypes()
        {
            this.currentFlourTypes.Add("white", 1.5);
            this.currentFlourTypes.Add("wholegrain", 1.0);
        }

        private void SeedBackingTechniques()
        {
            this.currentBackingTechniques.Add("chewy", 1.1);
            this.currentBackingTechniques.Add("homemade", 1.0);
            this.currentBackingTechniques.Add("crispy", 0.9);
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
