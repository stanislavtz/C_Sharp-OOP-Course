using System.Text;
using System.Collections.Generic;

namespace Military_Elite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        private string[] args;

        public Engineer(string id, string firstName, string lastName, decimal salary, string corps, string[] args)
            : base(id, firstName, lastName, salary, corps)
        {
            this.args = args;
            this.Repairs = new Dictionary<string, int>();
        }

        public Dictionary<string, int> Repairs { get; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"Repairs:");

            foreach (var repair in this.Repairs)
            {
                sb.AppendLine($"  Part Name: {repair.Key} Hours Worked: {repair.Value}");
            }

            return sb.ToString();
        }
    }
}
