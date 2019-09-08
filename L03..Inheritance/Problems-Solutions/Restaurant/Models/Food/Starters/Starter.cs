namespace Restaurant.Models.Food.Starters
{
    public class Starter : Food
    {
        public Starter(string name, decimal price, double grams) 
            : base(name, price, grams)
        {
        }
    }
}
