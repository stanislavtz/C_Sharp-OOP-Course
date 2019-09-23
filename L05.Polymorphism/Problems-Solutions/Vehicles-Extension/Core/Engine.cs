using System;
using System.Collections.Generic;
using System.Linq;
using Vehicles_Extension.Contracts;
using Vehicles_Extension.Models;

namespace Vehicles_Extension.Core
{
    public class Engine
    {
        private const int NUM_VEHICLES = 3;

        private string comandType;
        private string vehicleType;

        private double distanceToCover;
        private double fuelAmount;

        private IVehicle vehicle;
        private IVehicle currentVehicle;

        public void Run()
        {
            List<IVehicle> vehicles = new List<IVehicle>();

            for (int i = 0; i < NUM_VEHICLES; i++)
            {
                string[] vehicleArgs = Console.ReadLine().Split();

                double fuelQtty = double.Parse(vehicleArgs[1]);
                double consumtion = double.Parse(vehicleArgs[2]);
                double tankCapacity = double.Parse(vehicleArgs[3]);

                if (i == 0)
                {
                    vehicle = new Car(fuelQtty, consumtion, tankCapacity);
                }
                else if (i == 1)
                {
                    vehicle = new Truck(fuelQtty, consumtion, tankCapacity);
                }
                else if (i == 2)
                {
                    vehicle = new Bus(fuelQtty, consumtion, tankCapacity);
                }

                vehicles.Add(vehicle);
            }

            int numbercommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbercommands; i++)
            {
                try
                {
                    string[] commandArgs = Console.ReadLine().Split();

                    comandType = commandArgs[0];
                    vehicleType = commandArgs[1];

                    switch (comandType)
                    {
                        case "Drive":
                            distanceToCover = double.Parse(commandArgs[2]);

                            currentVehicle = vehicles.FirstOrDefault(v => v.GetType().Name == vehicleType);

                            currentVehicle.AirConditionOn();
                            currentVehicle.Drive(distanceToCover);

                            Console.WriteLine(currentVehicle);

                            break;

                        case "Refuel":
                            fuelAmount = double.Parse(commandArgs[2]);

                            currentVehicle = vehicles.FirstOrDefault(v => v.GetType().Name == vehicleType);

                            currentVehicle.Refuel(fuelAmount);

                            break;

                        case "DriveEmpty":
                            distanceToCover = double.Parse(commandArgs[2]);

                            currentVehicle = vehicles.FirstOrDefault(v => v.GetType().Name == "Bus");

                            currentVehicle.Drive(distanceToCover);

                            Console.WriteLine(currentVehicle);
                           
                            break;
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    if (comandType == "Drive")
                    {
                        currentVehicle.AirConditionOff();
                    }
                }
            }

            Console.WriteLine(string.Join(
                Environment.NewLine, vehicles
                .Select(v => $"{v.GetType().Name}: {v.FuelQtty:f2}")));
        }
    }
}
