using System;

namespace P05_GreedyTimes.Models
{
    public abstract class Precious : IPrecious
    {
        private int qtty;

        protected Precious(string preciousType, int qtty)
        {
            this.PreciousType = preciousType;
            this.Quantity = qtty;
        }

        public string PreciousType { get; private set; }

        public int Quantity
        {
            get => this.qtty;
            internal set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid value!");
                }

                this.qtty = value;
            }
        }
    }
}