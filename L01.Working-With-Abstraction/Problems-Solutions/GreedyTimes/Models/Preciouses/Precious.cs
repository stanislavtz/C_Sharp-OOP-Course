using System;

namespace P05_GreedyTimes.Models
{
    public abstract class Precious : IPrecious
    {
        protected Precious(string preciousType, int qtty)
        {
            this.PreciousType = preciousType;
            this.Quantity = qtty;
        }

        public string PreciousType { get; private set; }

        public int Quantity { get; set; }
    }
}