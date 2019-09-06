namespace NeedForSpeed.Cars
{
    public class SportCar : Car
    {
        public SportCar(double fuel, int horsePower) :
            base(fuel, horsePower)
        {

        }

        public virtual double FuelConsumption => 10;
    }
}
