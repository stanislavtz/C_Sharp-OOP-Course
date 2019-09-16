using Military_Elite.Contracts;
using System.Collections.Generic;

namespace Military_Elite.Models
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public abstract List<Soldier> Marines { get; }

        public abstract List<Soldier> AirForces { get; }
    }
}
