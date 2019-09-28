namespace P03_JediGalaxy
{
    using System;
    using System.Linq;
    using P03_JediGalaxy.Models;
    using P03_JediGalaxy.Models.Players;

    public class Engine
    {
        private Player mainPlayer;
        private Player evilPlayer;

        public void Run()
        {
            string command = Console.ReadLine();

            int[] dimestionsArgs = ElementInitialPosition(command);

            int row = dimestionsArgs[0];
            int col = dimestionsArgs[1];

            Space space = new Space(row, col);

            command = Console.ReadLine();

            long collectedStars = 0;

            while (command != "Let the Force be with you")
            {
                int[] playerArgs = ElementInitialPosition(command);
                int playerRow = playerArgs[0];
                int playersCol = playerArgs[1];

                command = Console.ReadLine();

                int[] evilArgs = ElementInitialPosition(command);
                int eveilRow = evilArgs[0];
                int evilCol = evilArgs[1];

                mainPlayer = new MainPlayer(playerRow, playersCol, collectedStars);
                evilPlayer = new EvilPlayer(eveilRow, evilCol);

                evilPlayer.Move(space, eveilRow, evilCol);
                mainPlayer.Move(space, playerRow, playersCol);

                collectedStars = ((MainPlayer)mainPlayer).CollectedStars;
                command = Console.ReadLine();
            }

            Console.WriteLine(mainPlayer);
        }

        private static int[] ElementInitialPosition(string command)
        {
            return command
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }
    }
}
