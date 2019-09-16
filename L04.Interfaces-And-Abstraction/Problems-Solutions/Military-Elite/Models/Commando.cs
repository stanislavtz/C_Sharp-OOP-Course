using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        private string[] args;

        public Commando(string id, string firstName, string lastName, decimal salary, string corps, string[] args) 
            : base(id, firstName, lastName, salary, corps)
        {
            this.args = args;
            this.Missions = new Dictionary<string, string>();
        }

        public Dictionary<string, string> Missions { get; }

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
