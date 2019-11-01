using System;
using Traffic_Lights.Contracts;

namespace Traffic_Lights.Core
{
    public class Engine : IRunable
    {
        public void Run()
        {
            string[] lights = Console.ReadLine()
                .Split();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < lights.Length; j++)
                {
                    if (lights[j] == "Red")
                    {
                        lights[j] = "Green";
                    }
                    else if (lights[j] == "Green")
                    {
                        lights[j] = "Yellow";
                    }
                    else if (lights[j] == "Yellow")
                    {
                        lights[j] = "Red";
                    }
                }

                Console.WriteLine(string.Join(" ", lights));
            }
        }
    }
}
