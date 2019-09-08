using System;
using Animals.Models;
using Animals.Models.Animals;
using System.Collections.Generic;
using Animals.Models.Animals.Cats;

namespace Animals.Core
{
    public class Engine
    {
        private Animal animal;
        private string name;
        private int age;
        private string gender;

        private List<Animal> animals;

        public Engine()
        {
            animals = new List<Animal>();
        }

        public void Run()
        {
            string typeInput = Console.ReadLine();

            while (typeInput != "Beast!")
            {
                string[] args = Console.ReadLine().Split();

                name = args[0];
                age = int.Parse(args[1]);
                try
                {
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
                    }

                    animals.Add(animal);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                typeInput = Console.ReadLine();
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
