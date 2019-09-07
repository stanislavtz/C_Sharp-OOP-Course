using System;

namespace NeedForSpeed.Models.Cars
{
    public class SportCar : Car
    {
        private const double DFAULT_FUEL_CONSUMPTION = 10;

        public SportCar(int horsePower, double fuel)
            : base(horsePower, fuel)
        {
        }

        public override void Drive()
        {
            bool canDrive = this.Fuel - DISTANCE * DFAULT_FUEL_CONSUMPTION  / 100 >= 0;

            if (!canDrive)
            {
                throw new ArgumentException("Not enought fuel in tank!");
            }

            this.Fuel -= DISTANCE * DFAULT_FUEL_CONSUMPTION / 100;
        }
    }
}
