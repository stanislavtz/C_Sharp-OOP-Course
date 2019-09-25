using Wild_Farm.Contracts;
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
            int foodEaten = 0;

            if (type == "Hen")
            {
                double wingSize = double.Parse(animalArgs[3]);

                return new Hen(name, weight, foodEaten, wingSize);
            }
            else if (type == "Owl")
            {
                double wingSize = double.Parse(animalArgs[3]);

                return new Owl(name, weight, foodEaten, wingSize);
            }
            else if (type == "Dog")
            {
                string livingRegion = animalArgs[3];

                return new Dog(name, weight, foodEaten, livingRegion);
            }
            else if (type == "Mouse")
            {
                string livingRegion = animalArgs[3];

                return new Mouse(name, weight, foodEaten, livingRegion);
            }
            else if (type == "Cat")
            {
                string livingRegion = animalArgs[3];
                string breed = animalArgs[4];

                return new Cat(name, weight, foodEaten, livingRegion, breed);
            }
            else if (type == "Tiger")
            {
                string livingRegion = animalArgs[3];
                string breed = animalArgs[4];

                return new Tiger(name, weight, foodEaten, livingRegion, breed);
            }

            return null;
        }
    }
}
