using System;
using System.Collections.Generic;
using System.Text;
using Wild_Farm.Models.Animals;
using Wild_Farm.Models.Animals.Birds;
using Wild_Farm.Models.Animals.Mammall;
using Wild_Farm.Models.Animals.Mammall.Felines;
using Wild_Farm.Models.Foods;

namespace Wild_Farm.Factories
{
    public class AnimalFactory
    {
        public Animal CreatAnimal(params string[] animalArgs)
        {
            string type = animalArgs[0];
            string name = animalArgs[1];
            double weight = double.Parse(animalArgs[2]);

            if (type == "Hen")
            {
                double wingSize = double.Parse(animalArgs[3]);

                return new Hen(name, weight, wingSize);
            }
            else if (type == "Owl")
            {
                double wingSize = double.Parse(animalArgs[3]);

                return new Owl(name, weight, wingSize);
            }
            else if (type == "Dog")
            {
                string livingRegion = animalArgs[3];

                return new Dog(name, weight, livingRegion);
            }
            else if (type == "Mouse")
            {
                string livingRegion = animalArgs[3];

                return new Mouse(name, weight, livingRegion);
            }
            else if (type == "Cat")
            {
                string livingRegion = animalArgs[3];
                string breed = animalArgs[4];

                return new Cat(name, weight, livingRegion, breed);
            }
            else if (type == "Tiger")
            {
                string livingRegion = animalArgs[3];
                string breed = animalArgs[4];

                return new Tiger(name, weight, livingRegion, breed);
            }

            return null;
        }
    }
}
