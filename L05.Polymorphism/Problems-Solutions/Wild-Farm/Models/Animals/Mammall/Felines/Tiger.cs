using System;
using System.Collections.Generic;
using Wild_Farm.Models.Foods;

namespace Wild_Farm.Models.Animals.Mammall.Felines
{
    public class Tiger : Feline
    {
        private const double FOOD_MODIFIER = 1;

        public Tiger(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        protected override List<Type> PrefferedFoodTpes => new List<Type> { typeof(Meat) };

        protected override double WeightMultiplier => FOOD_MODIFIER;

        public override string AskFood()
        {
            return "ROAR!!!";
        }
    }
}
