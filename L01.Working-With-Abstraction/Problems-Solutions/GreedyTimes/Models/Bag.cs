using System.Collections.Generic;

namespace P05_GreedyTimes.Models
{
    public class Bag
    {
        private readonly Dictionary<string, List<IPrecious>> bagContent;

        public Bag(int capacity)
        {
            this.Capacity = capacity;

            this.bagContent = new Dictionary<string, List<IPrecious>>();
        }

        public int Capacity { get; private set; }

        public IReadOnlyDictionary<string, List<IPrecious>> BagContent => this.bagContent;

        public void AddPrecious(IPrecious precious)
        {
            string preciouseType = precious.GetType().Name;

            if (!this.bagContent.ContainsKey(preciouseType))
            {
                this.bagContent.Add(preciouseType, new List<IPrecious>());
            }

            if (!this.bagContent[preciouseType].Contains(precious))
            {
                this.bagContent[preciouseType].Add(precious);
            }
            else
            {
                this.bagContent[preciouseType][this.bagContent[preciouseType].IndexOf(precious)].Quantity += precious.Quantity;
            }
        }
    }
}
