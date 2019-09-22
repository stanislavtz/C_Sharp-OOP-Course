using System;
using Vehicles_Extension.Models;
using Vehicles_Extention.Contracts;
using Vehicles_Extention.Models;

namespace Vehicles_Extention.Core
{
    public class Engine
    {
        private double fuelQtty;
        private double consumtion;
        private double tankCapacity;

        private double distanceToCover;

        public void Run()
        {
            string[] carInfo = Console.ReadLine().Split();
            fuelQtty = double.Parse(carInfo[1]);
            consumtion = double.Parse(carInfo[2]);
            tankCapacity = double.Parse(carInfo[3]);

            IVehicle car = new Car(fuelQtty, consumtion, tankCapacity);

            string[] truckInfo = Console.ReadLine().Split();
            fuelQtty = double.Parse(truckInfo[1]);
            consumtion = double.Parse(truckInfo[2]);
            tankCapacity = double.Parse(truckInfo[3]);

            IVehicle truck = new Truck(fuelQtty, consumtion, tankCapacity);

            string[] busInfo = Console.ReadLine().Split();
            fuelQtty = double.Parse(busInfo[1]);
            consumtion = double.Parse(busInfo[2]);
            tankCapacity = double.Parse(busInfo[3]);

            IVehicle bus = new Bus(fuelQtty, consumtion, tankCapacity);

            int numbercommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbercommands; i++)
            {
                try
                {
                    string[] commandArgs = Console.ReadLine().Split();

                    string comandType = commandArgs[0];
                    string vehicleType = commandArgs[1];

                    switch (comandType)
                    {
                        case "Drive":
                            distanceToCover = double.Parse(commandArgs[2]);

                            switch (vehicleType)
                            {
                                case "Car":
                                    try
                                    {
                                        car.AirConditionOn();
                                        car.Drive(distanceToCover);
                                        Console.WriteLine(car);
                                    }
                                    catch (ArgumentException ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                    }
                                    finally
                                    {
                                        car.AirConditionOff();
                                    }
                                    break;
                                case "Truck":
                                    try
                                    {
                                        truck.AirConditionOn();
                                        truck.Drive(distanceToCover);
                                        Console.WriteLine(truck);
                                    }
                                    catch (ArgumentException ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                    }
                                    finally
                                    {
                                        truck.AirConditionOff();
                                    }
                                    break;
                                case "Bus":
                                    try
                                    {
                                        bus.AirConditionOn();
                                        bus.Drive(distanceToCover);
                                        Console.WriteLine(bus);
                                    }
                                    catch (ArgumentException ex)
                                    {
                                        Console.WriteLine(ex.Message);
                                    }
                                    finally
                                    {
                                        bus.AirConditionOff();
                                    }
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
                                case "Bus":
                                    bus.Refuel(fuelAmount);
                                    break;
                            }
                            break;
                        case "DriveEmpty":
                            distanceToCover = double.Parse(commandArgs[2]);

                            bus.Drive(distanceToCover);
                            Console.WriteLine(bus);
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
            Console.WriteLine($"Bus: {bus.FuelQtty:f2}");
        }
    }
}
