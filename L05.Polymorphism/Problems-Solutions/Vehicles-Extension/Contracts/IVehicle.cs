namespace Vehicles_Extention.Contracts
{
    public interface IVehicle
    {
        double FuelQtty { get; }

        double Consumption { get; }

        double Refuel(double fuelAmount);

        double Drive(double distance);

        double AirConditionOn();

        double AirConditionOff();
    }
}
