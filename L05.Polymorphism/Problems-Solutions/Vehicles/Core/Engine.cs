using System;
using Vehicles.Contracts;
using Vehicles.Models;

namespace Vehicles.Core
{
    public class Engine
    {
        private double fuelQtty;
        private double consumption;

        public void Run()
        {
            string[] carInfo = Console.ReadLine().Split();

            fuelQtty = double.Parse(carInfo[1]);
            consumption = double.Parse(carInfo[2]);

            IVehicle car = new Car(fuelQtty, consumption);
            car.AirConditionOn();

            string[] truckInfo = Console.ReadLine().Split();

            fuelQtty = double.Parse(truckInfo[1]);
            consumption = double.Parse(truckInfo[2]);

            IVehicle truck = new Truck(fuelQtty, consumption);
            truck.AirConditionOn();

            int numbercommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbercommands; i++)
            {
                string[] commandArgs = Console.ReadLine().Split();

                string comandType = commandArgs[0];
                string vehicleType = commandArgs[1];

                try
                {
                    switch (comandType)
                    {
                        case "Drive":
                            double distanceToCover = double.Parse(commandArgs[2]);

                            switch (vehicleType)
                            {
                                case "Car":
                                    car.Drive(distanceToCover);
                                    Console.WriteLine(car);
                                    break;
                                case "Truck":
                                    truck.Drive(distanceToCover);
                                    Console.WriteLine(truck);
                                    break;
                            }
                            break;

                        case "Refuel":
                            double fuelAmount = double.Parse(commandArgs[2]);

                            switch (vehicleType)
                            {
                                case "Car":
                                    car.Refuel(fuelAmount);
                                    break;
                                case "Truck":
                                    truck.Refuel(fuelAmount);
                                    break;
                            }
                            break;
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine($"Car: {car.FuelQtty:f2}");
            Console.WriteLine($"Truck: {truck.FuelQtty:f2}");
        }
    }
}
