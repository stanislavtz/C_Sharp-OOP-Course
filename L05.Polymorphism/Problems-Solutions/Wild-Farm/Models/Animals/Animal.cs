using System.Linq;
using Wild_Farm.Contracts;
using Wild_Farm.Exceptions;
using Wild_Farm.Models.Foods;

namespace Wild_Farm.Models.Animals
{
    public abstract class Animal : IAnimal
    {
        private string name;
        private double weight;

        public Animal(string name, double weight)
        {
            this.Name = name;
            this.Weight = weight;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (value.Length < 2 || !value.Any(v => char.IsLetterOrDigit(v)))
                {
                    throw new InvalidNameLengthException();
                }

                this.name = value;
            }
        }

        public double Weight
        {
            get => this.weight;
            protected set
            {
                if (value <= 0)
                {
                    throw new InvalidWeightException();
                }
                this.weight = value;
            }
        }

        public int FoodEaten { get; private set; }

        public abstract string AskFood();

        public abstract double EatFood(Food food);

        public abstract void AddFood(string foodType);

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name},";
        }
    }
}
