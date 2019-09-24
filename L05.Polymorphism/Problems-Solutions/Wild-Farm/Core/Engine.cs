using System;
using System.Collections.Generic;
using System.Text;
using Wild_Farm.Contracts;
using Wild_Farm.Factories;
using Wild_Farm.Models.Animals.Birds;
using Wild_Farm.Models.Foods;

namespace Wild_Farm.Core
{
    public class Engine
    {
        public void Run()
        {
            List<IAnimal> animals = new List<IAnimal>();

            while (true)
            {
                string[] animalArgs = Console.ReadLine().Split();

                if (animalArgs[0] == "End")
                {
                    break;
                }

                string[] foodArgs = Console.ReadLine().Split();

                var animal = new AnimalFactory().CreatAnimal(animalArgs);

                var food = new FoodFactory().CreatFood(foodArgs);

                try
                {
                    Console.WriteLine(animal.AskFood());
                    animal.EatFood(food);
                    Console.WriteLine(animal);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }
    }
}
