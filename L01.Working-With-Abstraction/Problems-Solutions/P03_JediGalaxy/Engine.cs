using System;
using System.Linq;

namespace P03_JediGalaxy
{
    public class Engine
    {
        private int[,] space;

        public void Run()
        {
            string command = Console.ReadLine();

            int[] dimestionsArgs = ElementInitialPosition(command);

            int row = dimestionsArgs[0];
            int col = dimestionsArgs[1];

            space = SpaceCreate(row, col);

            command = Console.ReadLine();
            long starsPointColected = 0;

            ElementsAction(ref command, ref starsPointColected);
        }

        private void ElementsAction(ref string command, ref long starsPointColected)
        {
            while (command != "Let the Force be with you")
            {
                int[] playerArgs = ElementInitialPosition(command);

                command = Console.ReadLine();
                int[] evilArgs = ElementInitialPosition(command);

                int eveilRow = evilArgs[0];
                int evilCol = evilArgs[1];
                EvilMove(space, ref eveilRow, ref evilCol);

                int playerRow = playerArgs[0];
                int playersCol = playerArgs[1];
                PlayerMove(space, ref starsPointColected, ref playerRow, ref playersCol);

                command = Console.ReadLine();
            }

            Console.WriteLine(starsPointColected);
        }

        private static int[,] SpaceCreate(int row, int col)
        {
            var space = new int[row, col];

            int value = 0;

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    space[i, j] = value++;
                }
            }

            return space;
        }

        private static void PlayerMove(int[,] matrix, ref long starsSum, ref int row, ref int col)
        {
            while (row >= 0 && col < matrix.GetLength(1))
            {
                if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
                {
                    starsSum += matrix[row, col];
                }

                col++;
                row--;
            }
        }

        private static void EvilMove(int[,] matrix, ref int row, ref int col)
        {
            while (row >= 0 && col >= 0)
            {
                if (row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1))
                {
                    matrix[row, col] = 0;
                }

                row--;
                col--;
            }
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
