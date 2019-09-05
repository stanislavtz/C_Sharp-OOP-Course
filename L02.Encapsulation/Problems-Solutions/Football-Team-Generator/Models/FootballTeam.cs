using System;
using System.Linq;
using System.Collections.Generic;
using Football_Team_Generator.Exceptions;

namespace Football_Team_Generator.Models
{
    public class FootballTeam
    {
        private string name;
        private readonly List<Player> team;

        public FootballTeam(string name)
        {
            this.Name = name;
            this.team = new List<Player>();
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

        public void AddPlayer(Player player)
        {
            team.Add(player);
        }

        public void RemovePlayer(Player player)
        {
            var playerToRemove = team.FirstOrDefault(p => p.Name == player.Name);

            if (playerToRemove == null)
            {
                throw new NullReferenceException(string.Format(DataValidationExceptions.UnavailablePlayerException(), player.Name, this.Name));
            }

            team.Remove(playerToRemove);
        }

        public double CalculateRating()
        {
            return this.team.Average(p => p.PlayerRating());
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.CalculateRating()}";
        }
    }
}
