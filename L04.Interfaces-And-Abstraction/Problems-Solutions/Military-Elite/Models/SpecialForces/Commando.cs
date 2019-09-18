using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace Military_Elite.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(string id, string firstName, string lastName, decimal salary, string corps, List<Mission> missions) 
            : base(id, firstName, lastName, salary, corps)
        {
            this.Missions = missions;
        }

        public IReadOnlyCollection<Mission> Missions { get; }

        public void CompleteMission(string codeName)
        {
            Mission currentMission = this.Missions.FirstOrDefault(m => m.CodeName == codeName);

            if (currentMission.State == "inProgress")
            {
                currentMission.State = "Finished";
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"Missions:");

            foreach (var mission in this.Missions)
            {
                sb.AppendLine($"  {mission}");
            }

            return sb.ToString();
        }
    }
}
