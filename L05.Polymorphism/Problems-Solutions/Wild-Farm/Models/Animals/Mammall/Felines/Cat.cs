using System;
using System.Collections.Generic;
using Wild_Farm.Models.Foods;

namespace Wild_Farm.Models.Animals.Mammall.Felines
{
    public class Cat : Feline
    {
        private const double FOOD_MODIFIER = 0.30;

        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {

        }

        protected override List<Type> PrefferedFoodTpes =>
            new List<Type>
            {
                typeof(Vegetable),
                typeof(Meat)
            };

        protected override double WeightMultiplier => FOOD_MODIFIER;

        public override string AskFood()
        {
            return "Meow";
        }
    }
}
