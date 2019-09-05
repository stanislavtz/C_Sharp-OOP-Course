using Football_Team_Generator.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Football_Team_Generator.Models
{
    public class Player
    {
        private string name;
        private readonly List<Stat> stats;

        public Player(string name)
        {
            this.Name = name;
            this.stats = new List<Stat>();
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(DataValidationExceptions.InvalidNameException());
                }
                this.name = value;
            }
        }

        public double PlayerRating()
        {
            return Math.Round(this.stats.Average(s => s.StatValue));
        }

        public void AddStats(Stat stat)
        {
            this.stats.Add(stat);
        }
    }
}