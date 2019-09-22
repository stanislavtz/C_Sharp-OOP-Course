namespace Vehicles_Extention.Exceptions
{
    public static class ExceptionsData
    {
        public static string NotEnoughFuel => "{0} needs refueling";

        public static string InvalidReuelQtty => "Too many fuel. Try with less mount";

        public static string InvalidThankCapacity => "Tank capacity must be positive value!";

        public static string InvalidFuelValue => "Fuel quantity must be null or posotive value!";

        public static string InvalidFuelConsumptionValue => "Consumption must be positive value";

        public static string NegativeRefuelQuantity => "Fuel must be a positive number";

        public static string HighRefuelAmount => "Cannot fit {0} fuel in the tank";
    }
}
