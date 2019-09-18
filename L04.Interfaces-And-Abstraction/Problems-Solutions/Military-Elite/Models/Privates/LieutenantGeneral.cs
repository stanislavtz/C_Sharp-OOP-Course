using System.Text;
using Military_Elite.Contracts;
using System.Collections.Generic;

namespace Military_Elite.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private readonly List<IPrivate> privates;

        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary) 
            : base(id, firstName, lastName, salary)
        {
            this.privates = new List<IPrivate>();
        }

        public IReadOnlyCollection<IPrivate> Privates => this.privates;

        public void AddSoldier(IPrivate soldier)
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
