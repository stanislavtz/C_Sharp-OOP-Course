namespace NeedForSpeed
{
    public class Car : Vehicle
    {
        public Car(double fuel, int horsePower) :
            base(fuel, horsePower)
        {

        }

        public virtual double FuelConsumption => 3;
    }
}
