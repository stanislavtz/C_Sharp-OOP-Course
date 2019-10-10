using System.Collections.Generic;

namespace P05_GreedyTimes.Models
{
    public class Gold : Precious
    {
        private List<Gold> goldCollection;

        public Gold(string goldType, int qtty) 
            : base(goldType, qtty)
        {
        }
    }
}
