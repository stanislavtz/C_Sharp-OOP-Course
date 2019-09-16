using System;
using System.Text;
using Military_Elite.Contracts;
using System.Collections.Generic;

namespace Military_Elite.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public List<Private> Privets => throw new NotImplementedException();

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"Privates:");
            foreach (var privet in this.Privets)
            {
                sb.AppendLine($"  {base.ToString()}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
