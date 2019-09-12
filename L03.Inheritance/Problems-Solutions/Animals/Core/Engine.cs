using System;
using Animals.Models;
using Animals.Models.Animals;
using System.Collections.Generic;
using Animals.Models.Animals.Cats;

namespace Animals.Core
{
    public class Engine
    {
        private string name;
        private int age;
        private string gender;

        private Animal animal;
        private readonly List<Animal> animals;

        public Engine()
        {
            animals = new List<Animal>();
        }

        public void Run()
        {
            while (true)
            {
                string typeInput = Console.ReadLine();

                if (typeInput == "Beast!")
                {
                    break;
                }

                string[] args = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    if (args.Length != 3 || string.IsNullOrWhiteSpace(typeInput))
                    {
                        throw new ArgumentException("Invalid input!");
                    }

                    name = args[0];
                    bool isAge = int.TryParse(args[1], out age);

                    if (!isAge)
                    {
                        throw new ArgumentException("Invalid input!");
                    }

                    switch (typeInput)
                    {
                        case "Dog":
                            gender = args[2];
                            animal = new Dog(name, age, gender);
                            break;
                        case "Frog":
                            gender = args[2];
                            animal = new Frog(name, age, gender);
                            break;
                        case "Cat":
                            gender = args[2];
                            animal = new Cat(name, age, gender);
                            break;
                        case "Tomcat":
                            animal = new Tomcat(name, age);
                            break;
                        case "Kitten":
                            animal = new Kitten(name, age);
                            break;
                        default: 
                            throw new ArgumentException("Invalid input!");
                    }

                    animals.Add(animal);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
