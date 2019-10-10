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
    }
}
