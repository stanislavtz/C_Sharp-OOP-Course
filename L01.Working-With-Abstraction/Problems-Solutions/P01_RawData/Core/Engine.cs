using P01_RawData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P01_RawData.Core
{
    public class Engine
    {
        private readonly List<Car> cars;
        private List<Tire> tires;

        public Engine()
        {
            this.cars = new List<Car>();
        }

        public void Run()
        {
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                tires = new List<Tire>();

                string[] args = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = args[0];

                int engineSpeed = int.Parse(args[1]);
                int enginePower = int.Parse(args[2]);
                var engine = new CarEngine(engineSpeed, enginePower);

                int cargoWeight = int.Parse(args[3]);
                string cargoType = args[4];
                var cargo = new Cargo(cargoWeight, cargoType);

                CreateTireCollection(args);
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

        private void CreateTireCollection(string[] args)
        {
            for (int j = 5; j < 13; j += 2)
            {
                double tirePressure = double.Parse(args[j]);
                int tireAge = int.Parse(args[j + 1]);
                var tire = new Tire(tirePressure, tireAge);

                tires.Add(tire);
            }
        }
    }
}
