using System.Collections.Generic;

namespace P05_GreedyTimes.Models
{
    public class Cash : Precious
    {
        private List<Cash> cashCollection;

        public Cash(string cashType, int qtty) 
            : base(cashType, qtty)
        {
        }
    }
}
