using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Dictionary<string, string> Missions => throw new NotImplementedException();

        public void CompleteMission()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"Missions:");

            foreach (var mission in this.Missions)
            {
                sb.AppendLine($"  Code Name: {mission.Key} State: {mission.Value}");
            }

            return sb.ToString();
        }
    }
}
