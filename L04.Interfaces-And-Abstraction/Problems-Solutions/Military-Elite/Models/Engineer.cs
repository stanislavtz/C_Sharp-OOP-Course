using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {

        public Dictionary<string, int> Repairs => throw new NotImplementedException();

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
