namespace P05_GreedyTimes.Models
{
    public abstract class Precious
    {
        public Precious(int quantity)
        {
            this.Count = quantity;
        }

        public int Count { get; private set; }
    }
}
