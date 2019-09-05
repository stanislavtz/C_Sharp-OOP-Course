using System;
using Football_Team_Generator.Exceptions;

namespace Football_Team_Generator.Models
{
    public class Stat
    {
        private string name;
        private int statValue;

        public Stat(string name, int statValue)
        {
            this.name = name;
            this.StatValue = statValue;
        }

        public int StatValue
        {
            get => this.statValue;
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException(string.Format(DataValidationExceptions.InvalidStatException(), this.name));
                }
                this.statValue = value;
            }
        }
    }
}