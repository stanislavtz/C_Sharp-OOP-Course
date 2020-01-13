using System;
using System.Collections.Generic;
using Wild_Farm.Models.Foods;

namespace Wild_Farm.Models.Animals.Birds
{
    public class Owl : Bird
    {
        private const double FOOD_MODIFIER = 0.25;

        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        protected override List<Type> PrefferedFoodTpes =>
            new List<Type> { typeof(Meat) };

        protected override double WeightMultiplier => FOOD_MODIFIER;

        public override string AskFood()
        {
            return "Hoot Hoot";
        }
    }
}
