using System;
using System.Collections.Generic;
using System.Text;
using Wild_Farm.Models.Foods;

namespace Wild_Farm.Models.Animals.Mammall.Felines
{
    public class Tiger : Feline
    {
        private const double FOOD_MODIFIER = 1;

        private readonly List<string> preferedFood = new List<string>()
        {
            "Meat"
        };

        public Tiger(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override void AddFood(string foodType)
        {
            throw new NotImplementedException();
        }

        public override string AskFood()
        {
            return "ROAR!!!";
        }

        public override double EatFood(Food food)
        {
            string foodName = food.GetType().Name;

            if (!preferedFood.Contains(foodName))
            {
                throw new InvalidOperationException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }

            this.Weight += (this.FoodEaten * FOOD_MODIFIER);

            return this.Weight;
        }
    }
}
