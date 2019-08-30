using System;
using System.Linq;

namespace AnimalFarm.Models
{
    public class Engine
    {
        private Chicken chicken;
        private string name;
        private string ageInput;
        private int age;

        public void Run()
        {
            name = Console.ReadLine();
            ageInput = Console.ReadLine().ToLower();

            while (ageInput.Any(x => !char.IsDigit(x)) && ageInput != "exit")
            {
                Console.WriteLine("The ages must be an integer number!");

                ageInput = Console.ReadLine().ToLower();
            }

            if (ageInput == "exit")
            {
                return;
            }

            bool isAge = int.TryParse(ageInput, out age);

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
