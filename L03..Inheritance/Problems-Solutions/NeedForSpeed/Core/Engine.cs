using NeedForSpeed.Models;
using NeedForSpeed.Models.Cars;

namespace NeedForSpeed.Core
{
    public class Engine
    {
        public void Run()
        {
            Vehicle car = new SportCar(550, 100);
            car.Drive(100);
            System.Console.WriteLine(car);
        }
    }
}
