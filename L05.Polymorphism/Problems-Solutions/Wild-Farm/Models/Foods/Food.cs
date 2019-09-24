using Wild_Farm.Contracts;
using Wild_Farm.Exceptions;

namespace Wild_Farm.Models.Foods
{
    public abstract class Food : IFood
    {
        private int quantity;

        public Food(int quantity)
        {
            this.Quantity = quantity;
        }

        public int Quantity
        {
            get => this.quantity;
            private set
            {
                if (value <= 0)
                {
                    throw new InvalidFoodQuantityException();
                }

                this.quantity = value;
            }
        }
    }
}
