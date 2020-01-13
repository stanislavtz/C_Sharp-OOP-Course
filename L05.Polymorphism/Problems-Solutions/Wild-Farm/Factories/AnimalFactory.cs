using System;
using Wild_Farm.Contracts;
using Wild_Farm.Exceptions;
using Wild_Farm.Models.Animals.Birds;
using Wild_Farm.Models.Animals.Mammall;
using Wild_Farm.Models.Animals.Mammall.Felines;

namespace Wild_Farm.Factories
{
    public class AnimalFactory
    {
        public IAnimal CreatAnimal(params string[] animalArgs)
        {
            string type = animalArgs[0];
            string name = animalArgs[1];
            double weight = double.Parse(animalArgs[2]);
            
            IAnimal animal;

            if (type == "Hen")
            {
                double wingSize = double.Parse(animalArgs[3]);

                animal = new Hen(name, weight, wingSize);
            }
            else if (type == "Owl")
            {
                double wingSize = double.Parse(animalArgs[3]);

                animal = new Owl(name, weight, wingSize);
            }
            else if (type == "Dog")
            {
                string livingRegion = animalArgs[3];

                animal = new Dog(name, weight, livingRegion);
            }
            else if (type == "Mouse")
            {
                string livingRegion = animalArgs[3];

                animal = new Mouse(name, weight, livingRegion);
            }
            else if (type == "Cat")
            {
                string livingRegion = animalArgs[3];
                string breed = animalArgs[4];

                animal = new Cat(name, weight, livingRegion, breed);
            }
            else if (type == "Tiger")
            {
                string livingRegion = animalArgs[3];
                string breed = animalArgs[4];

                animal = new Tiger(name, weight, livingRegion, breed);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAnimalException);
            }

            return animal;
        }
    }
}
