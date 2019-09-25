using System;
using System.Collections.Generic;
using Wild_Farm.Contracts;
using Wild_Farm.Factories;

namespace Wild_Farm.Core
{
    public class Engine
    {
        public void Run()
        {
            List<IAnimal> animals = new List<IAnimal>();

            string[] animalArgs = Console.ReadLine().Split();
            string firstElement = animalArgs[0];

            while (firstElement != "End")
            {
                IAnimal animal = GetAnimal(animalArgs);

                IFood food = GetFood();

                Console.WriteLine(animal.AskFood());

                animals.Add(animal);

                try
                {
                    animal.EatFood(food);
                    animal.FoodEaten += food.Quantity;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                animalArgs = Console.ReadLine().Split();
                firstElement = animalArgs[0];
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

        private static IFood GetFood()
        {
            string[] foodArgs = Console.ReadLine().Split();

            var food = new FoodFactory().CreatFood(foodArgs);

            return food;
        }

        private static IAnimal GetAnimal(string[] animalArgs)
        {
            return new AnimalFactory().CreatAnimal(animalArgs);
        }
    }
}
