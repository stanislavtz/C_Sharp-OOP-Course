using System;
using System.Linq;
using System.Collections.Generic;
using Football_Team_Generator.Models;

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
                        teamName = args[1];

                        var currentTeam = teamList.FirstOrDefault(x => x.Name == teamName);

                        if (currentTeam == null)
                        {
                            throw new NullReferenceException($"Team {teamName} does not exist.");
                        }

                        Console.WriteLine(currentTeam);
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

                        var currentTeam = teamList.FirstOrDefault(x => x.Name == teamName);

                        if (currentTeam == null)
                        {
                            throw new NullReferenceException($"Team {teamName} does not exist.");
                        }

                        currentTeam.AddPlayer(player);

                    }
                    else if (args[0] == "Remove")
                    {
                        teamName = args[1];
                        playerName = args[2];
                        var currentTeam = teamList.First(x => x.Name == teamName);
                        var currentPlayer = new Player(playerName);

                        currentTeam.RemovePlayer(currentPlayer);
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (NullReferenceException nex)
                {
                    Console.WriteLine(nex.Message);
                }

                input = Console.ReadLine();
            }
        }
    }
}
