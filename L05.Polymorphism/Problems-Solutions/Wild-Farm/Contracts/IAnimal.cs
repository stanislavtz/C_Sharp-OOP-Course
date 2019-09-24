using Wild_Farm.Models.Foods;

namespace Wild_Farm.Contracts
{
    public interface IAnimal
    {
        string Name { get; }

        double Weight { get; }

        int FoodEaten { get; }

        string AskFood();

        double EatFood(Food food);
    }
}