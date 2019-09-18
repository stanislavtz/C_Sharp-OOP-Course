using System.Text;
using System.Collections.Generic;
using Military_Elite.Contracts.SpecialForces;

namespace Military_Elite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        private List<IRepair> repairs;
        public Engineer(string id, string firstName, string lastName, decimal salary, string corps)
            : base(id, firstName, lastName, salary, corps)
        {
            repairs = new List<IRepair>();
        }

        public IReadOnlyCollection<IRepair> Repairs => this.repairs.AsReadOnly();

        public void AddRepair(IRepair repair)
        {
            repairs.Add(repair);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"Repairs:");

            foreach (var repair in this.Repairs)
            {
                sb.AppendLine($"  {repair}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
