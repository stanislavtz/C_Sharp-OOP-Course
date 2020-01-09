using System.Text;
using System.Collections.Generic;
using Military_Elite.Contracts;

namespace Military_Elite.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private readonly List<ISoldier> privates;

        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary) 
            : base(id, firstName, lastName, salary)
        {
            this.privates = new List<ISoldier>();
        }

        public IReadOnlyCollection<ISoldier> Privates => this.privates;

        public void AddSoldier(ISoldier soldier)
        {
            this.privates.Add(soldier);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"Privates:");

            foreach (var @private in this.Privates)
            {
                sb.AppendLine($"  {@private.ToString()}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
