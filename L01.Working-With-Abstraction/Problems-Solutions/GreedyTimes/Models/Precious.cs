namespace P05_GreedyTimes.Models
{
    public class Precious : IPrecious
    {
        public int Quantity { get; private set; } = 0;

        public void AddAmount(int amount)
        {
            this.Quantity += amount;
        }
    }
}
