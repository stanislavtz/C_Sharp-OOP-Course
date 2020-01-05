using System;
using System.Linq;
using System.Collections.Generic;
using Football_Team_Generator.Models;
using Football_Team_Generator.Exceptions;

namespace Football_Team_Generator.Core
{
    public class Engine
    {
        private readonly List<FootballTeam> teamsList;

        public Engine()
        {
            teamsList = new List<FootballTeam>();
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
                        var teamName = args[1];

                        FootballTeam currentTeam = this.teamsList.FirstOrDefault(x => x.Name == teamName);

                        if (currentTeam == null)
                        {
                            throw new NullReferenceException(
                                string.Format(DataValidationExceptions.UnavailableTeamException(), teamName));
                        }

                        Console.WriteLine(currentTeam);
                    }
                    else if (args[0] == "Team")
                    {
                        var teamName = args[1];
                        var team = new FootballTeam(teamName);

                        this.teamsList.Add(team);
                    }
                    else if (args[0] == "Add")
                    {
                        var teamName = args[1];
                        var playerName = args[2];

                        var player = new Player(playerName);

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

                        var currentTeam = this.teamsList.FirstOrDefault(x => x.Name == teamName);

                        if (currentTeam == null)
                        {
                            throw new NullReferenceException
                                (string.Format(DataValidationExceptions.UnavailableTeamException(), teamName));
                        }

                        currentTeam.AddPlayer(player);
                    }
                    else if (args[0] == "Remove")
                    {
                        var teamName = args[1];
                        var playerName = args[2];

                        var currentTeam = this.teamsList.FirstOrDefault(x => x.Name == teamName);

                        if (currentTeam == null)
                        {
                            throw new NullReferenceException
                                (string.Format(DataValidationExceptions.UnavailableTeamException(), teamName));
                        }

                        var currentPlayer = new Player(playerName);

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
