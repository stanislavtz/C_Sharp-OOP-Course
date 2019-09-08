using NeedForSpeed.Models;
using NeedForSpeed.Models.Cars;
using NeedForSpeed.Models.Motors;
using System;

namespace NeedForSpeed.Core
{
    public class Engine
    {
        private Vehicle car;
        public void Run()
        {
            car = new SportCar(550, 100);
            car.Drive(100);
            Console.WriteLine(car);

            car = new FamilyCar(550, 100);
            car.Drive(100);
            Console.WriteLine(car);

            car = new RaceMotorcycle(550, 100);
            car.Drive(100);
            Console.WriteLine(car);

            car = new CrossMotorcycle(550, 100);
            car.Drive(100);
            Console.WriteLine(car);
        }
    }
}
