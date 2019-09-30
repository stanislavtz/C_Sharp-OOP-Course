using System.Collections.Generic;

namespace P05_GreedyTimes.Models
{
    public class Bag
    {
        private readonly List<Precious> bagContent;

        public Bag(int capacity)
        {
            this.Capacity = capacity;

            this.bagContent = new List<Precious>();
        }

        public int Capacity { get; private set; }

        public IReadOnlyCollection<Precious> BagContent => this.bagContent;

        public void AddPrecious(Precious precious)
        {
            bagContent.Add(precious);
        }
    }
}
