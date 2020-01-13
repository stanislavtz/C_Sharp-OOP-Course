using System;
using System.Collections.Generic;
using Wild_Farm.Models.Foods;

namespace Wild_Farm.Models.Animals.Mammall
{
    public class Mouse : Mammal
    {
        private const double FOOD_MODIFIER = 0.10;

        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        protected override List<Type> PrefferedFoodTpes =>
            new List<Type>
            {
                typeof(Vegetable),
                typeof(Fruit)
            };

        protected override double WeightMultiplier => FOOD_MODIFIER;

        public override string AskFood()
        {
            return "Squeak";
        }
       
        public override string ToString()
        {
            return $"{base.ToString()} {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
