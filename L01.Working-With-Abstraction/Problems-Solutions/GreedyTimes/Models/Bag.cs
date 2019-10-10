using System.Collections.Generic;

namespace P05_GreedyTimes.Models
{
    public class Bag
    {
        private List<Gold> goldCollection;
        private List<Gem> gemCollection;
        private List<Cash> cashCollection;

        public Bag(int capacity)
        {
            this.Capacity = capacity;
        }

        public int Capacity { get; private set; }

        public IReadOnlyCollection<Gold> GoldCollection => this.goldCollection;
        public IReadOnlyCollection<Gem> GemCollection => this.gemCollection;
        public IReadOnlyCollection<Cash> CashCollection => this.cashCollection;

        public void AddGold(IPrecious precious)
        {
            this.goldCollection.Add((Gold)precious);
        }

        public void AddGem(IPrecious precious)
        {
            this.gemCollection.Add((Gem)precious);
        }

        public void AddCash(IPrecious precious)
        {
            this.cashCollection.Add((Cash)precious);
        }
    }
}
