using System;

namespace P05_GreedyTimes.Models
{
    public abstract class Precious : IPrecious
    {
        protected Precious(string preciousType, long qtty)
        {
            this.PreciousType = preciousType;
            this.Quantity = qtty;
        }

        public string PreciousType { get; private set; }

        public long Quantity { get; set; }
    }
}