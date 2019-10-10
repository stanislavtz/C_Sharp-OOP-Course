using System.Collections.Generic;

namespace P05_GreedyTimes.Models
{
    public class Gem : Precious
    {
        private List<Gem> gemCollection;

        public Gem(string gemType, int qtty) 
            : base(gemType, qtty)
        {
        }
    }
}
