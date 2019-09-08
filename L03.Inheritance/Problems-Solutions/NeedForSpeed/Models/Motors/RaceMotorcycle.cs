namespace NeedForSpeed.Models.Motors
{
    public class RaceMotorcycle : Motorcycle
    {
        private const double DFAULT_FUEL_CONSUMPTION = 8;

        public RaceMotorcycle(int horsePower, double fuel) 
            : base(horsePower, fuel)
        {
        }

        public override double FuelConsumption => DFAULT_FUEL_CONSUMPTION;

        public override void Drive(double distance) => base.Drive(distance);
    }
}
