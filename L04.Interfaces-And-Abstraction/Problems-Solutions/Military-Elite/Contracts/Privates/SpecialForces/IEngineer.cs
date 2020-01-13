using System.Collections.Generic;

using Military_Elite.Contracts;
using Military_Elite.Contracts.SpecialForces;

namespace Military_Elite
{
    public interface IEngineer : ISpecialisedSoldier
    {
        IReadOnlyCollection<IRepair> Repairs { get; }

        void AddRepair(IRepair repair);
    }
}
