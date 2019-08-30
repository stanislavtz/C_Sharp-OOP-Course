using System;
using System.Text;

namespace P02_CarsSalesman
{
    public class Engine
    {
        private const string offset = "  ";

        private int displacement;
        private string efficiency;

        public Engine(string model, int power)
        {
            this.Model = model;
            this.Power = power;
            this.displacement = -1;
            this.efficiency = "n/a";
        }

        public string Model { get; private set; }

        public int Power{ get; private set; }

        public Engine(string model, int power, int displacement)
            : this(model, power)
        {
            this.displacement = displacement;
        }

        public Engine(string model, int power, string efficiency)
            : this(model, power)
        {
            this.efficiency = efficiency;
        }

        public Engine(string model, int power, int displacement, string efficiency)
            : this(model, power)
        {
            this.displacement = displacement;
            this.efficiency = efficiency;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{offset}{this.Model}:");
            sb.AppendLine($"{offset}{offset}Power: {this.Power}");
            sb.Append($"{offset}{offset}Displacement: ");
            sb.AppendFormat("{0}", this.displacement == -1 ? "n/a" : this.displacement.ToString());
            sb.AppendLine();
            sb.AppendLine($"{offset}{offset}Efficiency: {this.efficiency}");

            return sb.ToString();
        }
    }
}
