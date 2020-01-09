using System;
using System.Collections.Generic;
using System.Linq;
using Wild_Farm.Contracts;
using Wild_Farm.Factories;

namespace Wild_Farm.Core
{
    public class Engine
    {
        private List<IAnimal> animals;

        public Engine()
        {
            this.animals = new List<IAnimal>();
        }

        public void Run()
        {
            string command = Console.ReadLine();

            IAnimal animal = null;

            while (command != "End")
            {
                string[] animalArgs = command.Split().ToArray();

                command = Console.ReadLine();

                if (command == "End")
                {
                    return;
                }

                string[] foodArgs = command.Split().ToArray();

                try
                {
                    animal = new AnimalFactory().CreatAnimal(animalArgs);
                    var food = new FoodFactory().CreatFood(foodArgs);

                    Console.WriteLine(animal.AskFood());

                    animal.Feed(food);

                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }

                if (animal != null)
                {
                    animals.Add(animal);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(Environment.NewLine, animals));
        }
    }
}
