using Wild_Farm.Contracts;
using Wild_Farm.Models.Foods;

namespace Wild_Farm
{
    public class FoodFactory
    {
        public IFood CreatFood(params string[] foodArgs)
        {
            string type = foodArgs[0];
            int quantity = int.Parse(foodArgs[1]);

            if (type == "Fruit")
            {
                return new Fruit(quantity);
            }
            else if (type == "Meat")
            {
                return new Meat(quantity);
            }
            else if (type == "Seeds")
            {
                return new Seeds(quantity);
            }
            else if (type == "Vegetable")
            {
                return new Vegetable(quantity);
            }

            return null;
        }
    }
}
