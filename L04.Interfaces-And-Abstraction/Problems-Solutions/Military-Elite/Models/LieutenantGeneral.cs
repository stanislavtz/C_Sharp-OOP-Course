using System.Text;
using Military_Elite.Contracts;
using System.Collections.Generic;

namespace Military_Elite.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary) 
            : base(id, firstName, lastName, salary)
        {
            this.Privates = new List<Private>();
        }

        public List<Private> Privates { get; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"Privates:");
            foreach (var privet in this.Privates)
            {
                sb.AppendLine($"  {base.ToString()}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
