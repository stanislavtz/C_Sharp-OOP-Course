using System;

namespace P05_GreedyTimes.Models
{
    public abstract class Precious : IPrecious
    {
        private int qtty;

        protected Precious(string name, int qtty)
        {
            this.Name = name;
            this.Quantity = qtty;
        }

        public string Name { get; private set; }

        public int Quantity
        {
            get => this.qtty;
            set
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