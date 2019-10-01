namespace P05_GreedyTimes.Models
{
    public abstract class Precious : IPrecious
    {
        public Precious(string name, int qtty)
        {
            this.Name = name;
            this.Quantity = qtty;
        }

        public string Name  { get; private set; }

        public int Quantity { get; set; }

        public void AddAmount(int amount)
        {
            this.Quantity += amount;
        }
    }
}
