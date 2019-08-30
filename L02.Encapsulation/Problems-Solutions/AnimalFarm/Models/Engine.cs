using AnimalFarm.Contracts;
using System;

namespace AnimalFarm.Models
{
    public class Engine : IEngine
    {
        private Chicken chicken;
        private string name;
        private int age;

        public void Run()
        {
            name = Console.ReadLine();
            bool isAge = int.TryParse(Console.ReadLine(), out age);

            try
            {
                chicken = new Chicken(name, age);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            if (chicken != null)
            {
                Console.WriteLine(chicken);
            }
        }
    }
}
