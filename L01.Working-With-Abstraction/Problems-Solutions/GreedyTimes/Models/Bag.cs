using System.Collections.Generic;

namespace P05_GreedyTimes.Models
{
    public class Bag<T>
    {
        private readonly List<T> bagContent;

        public Bag(int capacity)
        {
            this.Capacity = capacity;

            this.bagContent = new List<T>();
        }

        public int Capacity { get; private set; }

        public List<T> BagContent => this.bagContent;

        public void AddPrecious(IPrecious precious)
        {
           
        }
    }
}
