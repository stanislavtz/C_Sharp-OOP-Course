using System;
using System.Linq;
using System.Collections.Generic;
using Football_Team_Generator.Exceptions;

namespace Football_Team_Generator.Models
{
    public class FootballTeam
    {
        private string name;
        private readonly List<Player> players;

        public FootballTeam(string name)
        {
            this.Name = name;
            this.players = new List<Player>();
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
            players.Add(player);
        }

        public double CalculateRating()
        {

            return this.players.Sum(p => p.PlayerRating());
        }

        public void RemovePlayer(Player player)
        {
            var playerToRemove = players.FirstOrDefault(p => p.Name == player.Name);

            if (playerToRemove == null)
            {
                throw new NullReferenceException($"Player {player.Name} is not in {this.Name} team.");
            }

            players.Remove(playerToRemove);
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.CalculateRating()}";
        }
    }
}
