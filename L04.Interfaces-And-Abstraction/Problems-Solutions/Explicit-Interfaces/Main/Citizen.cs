using Explicit_Interfaces.Contracts;
using System.Text;

namespace Explicit_Interfaces.Main
{
    public class Citizen : IResident, IPerson
    {
        public string Name { get; }

        public int Age { get; }

        string IResident.Name => "Mr/Ms/Mrs" ;

        string IResident.Country { get; }

        public string GetName(string name)
        {
            return this.Name;
        }

        string IResident.GetName()
        {
            return this.GetName(this.Name);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(this.GetName(this.Name));
            sb.AppendLine(this.IResident.GetName());
            return base.ToString();
        }
    }
}
