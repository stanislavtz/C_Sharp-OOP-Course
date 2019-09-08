namespace NeedForSpeed.Models.Cars
{
    public class SportCar : Car
    {
        private const double DFAULT_FUEL_CONSUMPTION = 10;

        public SportCar(int horsePower, double fuel)
            : base(horsePower, fuel)
        {
        }

        public override double FuelConsumption => DFAULT_FUEL_CONSUMPTION;

        public override void Drive(double distance) => base.Drive(distance);
    }
}
