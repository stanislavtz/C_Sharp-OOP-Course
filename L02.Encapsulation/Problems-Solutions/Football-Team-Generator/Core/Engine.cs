using System;
using System.Linq;
using System.Collections.Generic;
using Football_Team_Generator.Models;
using Football_Team_Generator.Exceptions;

namespace Football_Team_Generator.Core
{
    public class Engine
    {
        private readonly List<FootballTeam> teamList;
        private string teamName;
        private string playerName;
        private FootballTeam team;

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
                        this.teamName = args[1];

                        FootballTeam currentTeam = this.teamList.FirstOrDefault(x => x.Name == this.teamName);

                        if (currentTeam == null)
                        {
                            throw new NullReferenceException($"Team {this.teamName} does not exist.");
                        }

                        Console.WriteLine(currentTeam);
                    }
                    else if (args[0] == "Team")
                    {
                        this.teamName = args[1];
                        this.team = new FootballTeam(this.teamName);
                        this.teamList.Add(this.team);
                    }
                    else if (args[0] == "Add")
                    {
                        this.teamName = args[1];
                        this.playerName = args[2];

                        var player = new Player(this.playerName);

                        List<int> statValues = args.Skip(3).Select(int.Parse).ToList();

                        List<string> statsNames = new List<string>
                        {
                            "Endurance",
                            "Sprint",
                            "Dribble",
                            "Passing",
                            "Shooting"
                        };

                        for (int i = 0; i < statValues.Count; i++)
                        {
                            var stat = new Stat(statsNames[i], statValues[i]);

                            player.AddStats(stat);
                        }

                        var currentTeam = this.teamList.FirstOrDefault(x => x.Name == this.teamName);

                        if (currentTeam == null)
                        {
                            throw new NullReferenceException
                                (string.Format(DataValidationExceptions.UnavailableTeamException(), this.teamName));
                        }

                        currentTeam.AddPlayer(player);
                    }
                    else if (args[0] == "Remove")
                    {
                        this.teamName = args[1];
                        this.playerName = args[2];

                        var currentTeam = this.teamList.FirstOrDefault(x => x.Name == this.teamName);

                        if (currentTeam == null)
                        {
                            throw new NullReferenceException
                                (string.Format(DataValidationExceptions.UnavailableTeamException(), this.teamName));
                        }

                        var currentPlayer = new Player(this.playerName);

                        currentTeam.RemovePlayer(currentPlayer);
                    }
                    else
                    {
                        break;
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (NullReferenceException nRex)
                {
                    Console.WriteLine(nRex.Message);
                }

                input = Console.ReadLine();
            }
        }
    }
}
