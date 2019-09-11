using System;

namespace MordorsCruelPlan
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] foods = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            int currentPoints = 0;
            int totalPoints = 0;

            foreach (var food in foods)
            {
                switch (food.ToLower())
                {
                    case "cram":
                        currentPoints = 2;
                        break;
                    case "lembas":
                        currentPoints = 3;
                        break;
                    case "apple":
                        currentPoints = 1;
                        break;
                    case "melon":
                        currentPoints = 1;
                        break;
                    case "honeycake":
                        currentPoints = 5;
                        break;
                    case "mushrooms":
                        currentPoints = -10;
                        break;
                    default:
                        currentPoints = -1;
                        break;
                }

                totalPoints += currentPoints;
            }

            string mood = string.Empty;

            if (totalPoints < -5)
            {
                mood = "Angry";
            }
            else if (totalPoints <= 0)
            {
                mood = "Sad";
            }
            else if (totalPoints <= 15)
            {
                mood = "Happy";
            }
            else
            {
                mood = "JavaScript";
            }

            Console.WriteLine(totalPoints);
            Console.WriteLine(mood);
        }
    }
}
