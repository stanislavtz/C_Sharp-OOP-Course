using System.Collections.Generic;

namespace P05_GreedyTimes.Models
{
    public class Bag
    {
        private readonly List<IPrecious> bagContent;
        
        public Bag(int capacity)
        {
            this.Capacity = capacity;

            this.bagContent = new List<IPrecious>();
        }

        public int Capacity { get; private set; }

        public IReadOnlyCollection<IPrecious> BagContent => this.bagContent.AsReadOnly();

        public void AddPrecious(IPrecious precious)
        {
            this.bagContent.Add(precious);
        }
    }
}
