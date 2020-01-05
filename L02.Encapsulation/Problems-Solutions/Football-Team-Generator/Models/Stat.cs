using System;
using Football_Team_Generator.Exceptions;

namespace Football_Team_Generator.Models
{
    public class Stat
    {
        private const int MinStatValue = 0;
        private const int MaxStatValue = 100;

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
                if (value < MinStatValue || value > MaxStatValue)
                {
                    throw new ArgumentException
                        (string.Format(DataValidationExceptions.InvalidStatException(), this.name, MinStatValue, MaxStatValue));
                }

                this.statValue = value;
            }
        }
    }
}