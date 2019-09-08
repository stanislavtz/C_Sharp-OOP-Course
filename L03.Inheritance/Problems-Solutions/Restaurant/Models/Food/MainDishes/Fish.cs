namespace Restaurant.Models.Food.MainDishes
{
    public class Fish : MainDish
    {
        public const double Grams = 22;

        public Fish(string name, decimal price) 
            : base(name, price, Grams)
        {
        }
    }
}
