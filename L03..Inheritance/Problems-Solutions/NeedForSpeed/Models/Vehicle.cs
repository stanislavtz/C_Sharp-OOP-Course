namespace NeedForSpeed.Models
{
    public class Vehicle
    {
        private const double DFAULT_FUEL_CONSUMPTION = 1.25;

        public Vehicle(int horsePower, double fuel)
        {
            this.HorsePower = horsePower;
            this.Fuel = fuel;
        }

        public int HorsePower { get; set; }

        public double Fuel { get; set; }

        public virtual double FuelConsumption => DFAULT_FUEL_CONSUMPTION;

        public virtual void Drive(double distance)
        {
            bool canDrive = this.Fuel - this.FuelConsumption * distance >= 0;

            if (canDrive)
            {
                this.Fuel -= this.FuelConsumption * distance;
            }
        }
    }
}
