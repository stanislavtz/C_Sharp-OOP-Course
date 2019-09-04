using Football_Team_Generator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Football_Team_Generator.Core
{
    public class Engine
    {
        private List<FootballTeam> teamList;

        public Engine()
        {
            teamList = new List<FootballTeam>();
        }

        public void Run()
        {
            string input = Console.ReadLine();

            while (true)
            {
                string[] args = input
                    .Split(";", StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    if (args[0] == "Rating")
                    {
                        break;
                    }
                    else if (args[0] == "Team")
                    {
                        string teamName = args[1];
                        var team = new FootballTeam(teamName);
                        teamList.Add(team);
                    }
                    else if (args[0] == "Add")
                    {
                        string teamName = args[1];
                        string playerName = args[2];
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
