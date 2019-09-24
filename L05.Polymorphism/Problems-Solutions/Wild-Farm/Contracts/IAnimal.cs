using System.Collections.Generic;

namespace Wild_Farm.Contracts
{
    public interface IAnimal
    {
        string Name { get; }

        double Weight { get; }

        int FoodEaten { get; set; }

        string AskFood();

        double EatFood(IFood food);
    }
}