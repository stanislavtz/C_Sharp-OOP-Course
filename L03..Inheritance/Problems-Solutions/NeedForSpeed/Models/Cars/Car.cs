namespace NeedForSpeed.Models.Cars
{
    public class Car : Vehicle
    {
        private const double DFAULT_FUEL_CONSUMPTION = 3;

        public Car(int horsePower, double fuel)
            : base(horsePower, fuel)
        {
        }

        public override double FuelConsumption => DFAULT_FUEL_CONSUMPTION;

        public override void Drive(double distance)
        {
            base.Drive(distance);
        }
    }
}
