using Football_Team_Generator.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Football_Team_Generator.Models
{
    public class FootballTeam
    {
        private string name;
        private int rating;
        private readonly List<Player> players;

        public FootballTeam(string name)
        {
            this.Name = name;
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

        public double CalculateRating(List<Player> players)
        {

            return players.Sum(p => p.PlayerRating());
        }
    }
}
