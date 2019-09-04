using System;
using System.Collections.Generic;
using System.Linq;

namespace Football_Team_Generator.Models
{
    public class Player
    {
        private string name;
        private readonly List<Stat> stats;

        internal double TotalRating()
        {
            return Math.Round(stats.Average(s => s.StatValue));
        }
    }
}