using System.Linq;
using System.Text;

namespace P02_CarsSalesman
{
    public class Car
    {
        private const string offset = "  ";

        private string model;
        private Engine engine;
        private int weight;
        private string color;

        public Car(string model, Engine engine)
        {
            this.model = model;
            this.engine = engine;
            this.weight = -1;
            this.color = "n/a";
        }

        public Car(string model, Engine engine, int weight)
            : this(model, engine)
        {
            this.weight = weight;
        }

        public Car(string model, Engine engine, string color)
            : this(model, engine)
        {
            this.color = color;
        }

        public Car(string model, Engine engine, int weight, string color)
            :this(model, engine)
        {
            this.weight = weight;
            this.color = color;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.model}:");
            sb.Append(this.engine);
            sb.Append($"{offset}Weight: ");
            sb.AppendFormat("{0}", this.weight == -1 ? "n/a" : this.weight.ToString());
            sb.AppendLine();
            sb.AppendFormat("{0}Color: {1}", offset, this.color);

            return sb.ToString();
        }
    }

}
