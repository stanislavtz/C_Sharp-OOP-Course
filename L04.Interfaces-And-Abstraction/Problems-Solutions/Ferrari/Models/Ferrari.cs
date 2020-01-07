using Ferrari.Contracts;

namespace Ferrari
{
    public class Ferrari : IDriveable
    {
        private const string MODEL = "488-Spider";

        private readonly IDriver driver;

        public Ferrari(IDriver driver)
        {
            this.driver = driver;
        }

        public string PushBreaks()
        {
            return "Brakes!";
        }

        public string PushGas()
        {
            return "Gas!";
        }

        public override string ToString()
        {
            return $"{MODEL}/{this.PushBreaks()}/{this.PushGas()}/{this.driver.Name}";
        }
    }
}
