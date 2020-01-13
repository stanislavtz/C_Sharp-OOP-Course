using Military_Elite.Contracts.SpecialForces;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        private const string PATTERN = "  ";

        private readonly List<IMission> missions;

        public Commando(string id, string firstName, string lastName, decimal salary, string corps)
            : base(id, firstName, lastName, salary, corps)
        {
            this.missions = new List<IMission>();
        }

        public IReadOnlyCollection<IMission> Missions => this.missions;

        public void AddMission(IMission mission)
        {
            this.missions.Add(mission);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString())
              .AppendLine($"Missions:");

            foreach (var mission in this.Missions)
            {
                sb.AppendLine($"{PATTERN}{mission}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
