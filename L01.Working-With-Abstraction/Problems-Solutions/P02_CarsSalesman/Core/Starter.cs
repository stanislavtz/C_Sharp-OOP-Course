using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_CarsSalesman.Core
{
    public class Starter
    {
        private readonly List<Engine> engines = new List<Engine>();
        private readonly List<Car> cars = new List<Car>();

        private int engineCount;
        private string efficiency;
        private Engine engine;
        private Car car;

        public void Run()
        {
            engineCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < engineCount; i++)
            {
                string[] args = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = args[0];
                int power = int.Parse(args[1]);

                int displacement = -1;

                if (args.Length == 3 && int.TryParse(args[2], out displacement))
                {
                    engine = new Engine(model, power, displacement);

                    engines.Add(engine);
                }
                else if (args.Length == 3)
                {
                    efficiency = args[2];

                    engine = new Engine(model, power, efficiency);

                    engines.Add(new Engine(model, power, efficiency));
                }
                else if (args.Length == 4)
                {
                    string efficiency = args[3];

                    engines.Add(new Engine(model, power, int.Parse(args[2]), efficiency));
                }
                else
                {
                    engines.Add(new Engine(model, power));
                }
            }

            int carCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carCount; i++)
            {
                string[] parameters = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = parameters[0];
                string engineModel = parameters[1];

                engine = engines.FirstOrDefault(x => x.Model == engineModel);

                int weight = -1;

                if (parameters.Length == 3 && int.TryParse(parameters[2], out weight))
                {
                    car = new Car(model, engine, weight);

                    cars.Add(car);
                }
                else if (parameters.Length == 3)
                {
                    string color = parameters[2];

                    car = new Car(model, engine, color);

                    cars.Add(car);
                }
                else if (parameters.Length == 4)
                {
                    string color = parameters[3];
                    cars.Add(new Car(model, engine, int.Parse(parameters[2]), color));
                }
                else
                {
                    cars.Add(new Car(model, engine));
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
