using System;
using System.Linq;
using P01_RawData.Models;
using System.Collections.Generic;

namespace P01_RawData.Core
{
    public class Engine
    {
        private readonly List<Car> cars;
        private List<Tire> tires;

        public Engine()
        {
            this.cars = new List<Car>();
            this.tires = new List<Tire>();
        }

        public void Run()
        {
            int numberInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberInputs; i++)
            {
                string[] carArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = carArgs[0];

                int engineSpeed = int.Parse(carArgs[1]);
                int enginePower = int.Parse(carArgs[2]);

                int cargoWeight = int.Parse(carArgs[3]);
                string cargoType = carArgs[4];

                CarEngine engine = new CarEngine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);

                double[] tireArgs = carArgs.Skip(5).Select(double.Parse).ToArray();

                CreateTireCollection(tireArgs);
                CreateCarsCollection(model, engine, cargo);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                PrintFragileCargoCars();
            }
            else
            {
                PrintFlamableCargoCars();
            }
        }

        private void PrintFlamableCargoCars()
        {
            List<string> flamable = cars
                .Where(x => x.CargoType == "flamable" && x.EnginePower > 250)
                .Select(x => x.Model)
                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, flamable));
        }

        private void PrintFragileCargoCars()
        {
            List<string> fragile = cars
                                .Where(x => x.CargoType == "fragile" && x.Tires.Any(y => y.Presure < 1))
                                .Select(x => x.Model)
                                .ToList();

            Console.WriteLine(string.Join(Environment.NewLine, fragile));
        }

        private void CreateCarsCollection(string model, CarEngine engine, Cargo cargo)
        {
            var car = new Car(model, engine, cargo, tires);

            cars.Add(car);
        }

        private void CreateTireCollection(double[] tireArgs)
        {
            for (int j = 0; j < 8; j += 2)
            {
                double tirePressure = tireArgs[j];
                int tireAge = (int)tireArgs[j + 1];
                var tire = new Tire(tirePressure, tireAge);

                tires.Add(tire);
            }
        }
    }
}
