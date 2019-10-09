using System.Collections.Generic;
using System.Linq;

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
            if (bagContent.Any(b => b.Name == precious.Name))
            {
                bagContent.First(b => b.Name == precious.Name).Quantity += precious.Quantity;
            }
            else
            {
                bagContent.Add(precious);
            }

            var goldCollection = bagContent.Where(b => b.Name.ToLower() == "gold").ToArray();
            var currentGoldQtty = goldCollection.Sum(s => s.Quantity);

            var gemsCollection = bagContent.Where(b => b.Name.ToLower().EndsWith("gem")).ToArray();
            var currentGemsQtty = gemsCollection.Sum(s => s.Quantity);

            var cashCollection = bagContent.Where(b => b.Name.Length == 3).ToArray();
            var currentCashQtty = cashCollection.Sum(s => s.Quantity);


            if (currentGoldQtty > this.Capacity)
            {
                bagContent.Remove(precious);
            }
            else if(currentGemsQtty > currentGoldQtty)
            {
                bagContent.Remove(precious);
            }
            else if (currentCashQtty > currentGemsQtty)
            {
                bagContent.Remove(precious);
            }
        }
    }
}
