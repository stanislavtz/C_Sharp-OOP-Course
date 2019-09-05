using Football_Team_Generator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Football_Team_Generator.Core
{
    public class Engine
    {
        private List<FootballTeam> teamList;
        private FootballTeam team;
        private string teamName;
        private string playerName;

        public Engine()
        {
            teamList = new List<FootballTeam>();
        }

        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] args = input
                    .Split(";", StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    if (args[0] == "Rating")
                    {
                        ;
                    }
                    else if (args[0] == "Team")
                    {
                        teamName = args[1];
                        team = new FootballTeam(teamName);
                        teamList.Add(team);
                    }
                    else if (args[0] == "Add")
                    {
                        teamName = args[1];
                        playerName = args[2];

                        var player = new Player(playerName);

                        var stats = args.Skip(3).Select(int.Parse).ToList();
                        var statsNames = new List<string>
                        {
                            "Endurance",
                            "Sprint",
                            "Dribble",
                            "Passing",
                            "Shooting"
                        };

                        for (int i = 0; i < stats.Count; i++)
                        {
                            var stat = new Stat(statsNames[i], stats[i]);
                            player.AddStats(stat);
                        }

                        var result = player.PlayerRating();
                    }
                    else if (args[0] == "Remove")
                    {

                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                input = Console.ReadLine();
            }
        }
    }
}
