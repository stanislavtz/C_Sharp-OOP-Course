using Military_Elite.Contracts;
using Military_Elite.Contracts.SpecialForces;
using System.Collections.Generic;

namespace Military_Elite
{
    public interface ICommando : ISpecialisedSoldier
    {
        IReadOnlyCollection<IMission> Missions { get; }

        void AddMission(IMission mission);
    }
}
