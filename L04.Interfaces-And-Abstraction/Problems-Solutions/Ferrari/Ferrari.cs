using System;
using System.Collections.Generic;
using System.Text;

namespace Ferrari
{
    public class Ferrari : IFerrari
    {
        public Ferrari(string driver)
        {
            this.Driver = driver;
        }

        public string Driver { get; set; }

        public string Model => "488-Spider";

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
            return $"{this.Model}/{this.PushBreaks()}/{this.PushGas()}/{this.Driver}";
        }
    }
}
