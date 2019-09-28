namespace P02_CarsSalesman.Core
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Starter
    {
        private readonly List<Car> cars = new List<Car>();
        private readonly List<Engine> engines = new List<Engine>();

        private Car car;
        private Engine engine;

        public void Run()
        {
            string efficiency;

            int engineCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < engineCount; i++)
            {
                string[] engineArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = engineArgs[0];
                int power = int.Parse(engineArgs[1]);

                int displacement = -1;

                if (engineArgs.Length == 3 && int.TryParse(engineArgs[2], out displacement))
                {
                    this.engine = new Engine(model, power, displacement);

                    this.engines.Add(this.engine);
                }
                else if (engineArgs.Length == 3)
                {
                    efficiency = engineArgs[2];

                    this.engine = new Engine(model, power, efficiency);

                    this.engines.Add(new Engine(model, power, efficiency));
                }
                else if (engineArgs.Length == 4)
                {
                    efficiency = engineArgs[3];

                    this.engines.Add(new Engine(model, power, int.Parse(engineArgs[2]), efficiency));
                }
                else
                {
                    this.engines.Add(new Engine(model, power));
                }
            }

            int carCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carCount; i++)
            {
                string[] carArgs = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = carArgs[0];
                string engineModel = carArgs[1];

                this.engine = this.engines.FirstOrDefault(x => x.Model == engineModel);

                int weight = -1;

                if (carArgs.Length == 3 && int.TryParse(carArgs[2], out weight))
                {
                    this.car = new Car(model, engine, weight);

                    this.cars.Add(this.car);
                }
                else if (carArgs.Length == 3)
                {
                    string color = carArgs[2];

                    this.car = new Car(model, this.engine, color);

                    this.cars.Add(this.car);
                }
                else if (carArgs.Length == 4)
                {
                    string color = carArgs[3];
                    this.cars.Add(new Car(model, this.engine, int.Parse(carArgs[2]), color));
                }
                else
                {
                    this.cars.Add(new Car(model, this.engine));
                }
            }

            foreach (var car in this.cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
