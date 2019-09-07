using NeedForSpeed.Models.Cars;
using NeedForSpeed.Models.Motors;
using System;

namespace NeedForSpeed.Core
{
    public class Engine
    {
        public void Run()
        {
            try
            {
                var car1 = new SportCar(5, 70);
                car1.Drive();
                Console.WriteLine(car1.Fuel);

                var car2 = new FamilyCar(5, 70);
                car2.Drive();
                Console.WriteLine(car2.Fuel);

                var moto1 = new RaceMotorcycle(5, 70);
                moto1.Drive();
                Console.WriteLine(moto1.Fuel);

                var moto2 = new CrossMotorcycle(5, 70);
                moto2.Drive();
                Console.WriteLine(moto2.Fuel);

            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
