using System.Text;
using Explicit_Interfaces.Contracts;

namespace Explicit_Interfaces.Main
{
    public class Citizen : ICitizen, IResident, IPerson
    {
        public Citizen(string name, string country, int age)
        {
            this.Name = name;
            this.Country = country;
            this.Age = age;
        }

        public string Name { get; }

        public string Country { get; }

        public int Age { get; }

        public string GetName() => this.Name;

        string ICitizen.GetName() => $"Mr/Ms/Mrs";

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append($"{((ICitizen)this).GetName()} ");
            sb.AppendLine($"{this.Name}, ");
            sb.AppendLine($"Country: {this.Country}, ");
            sb.Append($"Age: {this.Age}");

            return sb.ToString();
        }
    }
}
