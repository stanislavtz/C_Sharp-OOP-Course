using System;

namespace NeedForSpeed.Models.Cars
{
    public abstract class Car : Vehicle
    {
        private const double DFAULT_FUEL_CONSUMPTION = 3;

        public Car(int horsePower, double fuel)
            : base(horsePower, fuel)
        {
        }

        public override void Drive()
        {
            bool canDrive = this.Fuel - DISTANCE * DFAULT_FUEL_CONSUMPTION / 100 >= 0;

            if (!canDrive)
            {
                throw new ArgumentException("Not enought fuel in tank!");
            }

            this.Fuel -= DISTANCE * DFAULT_FUEL_CONSUMPTION / 100;
        }
    }
}
