using System.Collections.Generic;
using System.Linq;

namespace P05_GreedyTimes.Models
{
    public class Bag
    {
        private readonly List<Gold> goldCollection;
        private readonly List<Gem> gemCollection;
        private readonly List<Cash> cashCollection;

        public Bag(int capacity)
        {
            this.Capacity = capacity;

            this.goldCollection = new List<Gold>();
            this.gemCollection = new List<Gem>();
            this.cashCollection = new List<Cash>();
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
            if (this.gemCollection.Any(p => p.PreciousType.ToLower() == precious.PreciousType.ToLower()))
            {
                this.gemCollection.First(p => p.PreciousType.ToLower() == precious.PreciousType.ToLower()).Quantity += precious.Quantity;
            }
            else
            {
                this.gemCollection.Add((Gem)precious);
            }
        }

        public void AddCash(IPrecious precious)
        {

            if (this.cashCollection.Any(p => p.PreciousType.ToLower() == precious.PreciousType.ToLower()))
            {
                this.cashCollection.First(p => p.PreciousType.ToLower() == precious.PreciousType.ToLower()).Quantity += precious.Quantity;
            }
            else
            {
                this.cashCollection.Add((Cash)precious);
            }
        }
    }
}
