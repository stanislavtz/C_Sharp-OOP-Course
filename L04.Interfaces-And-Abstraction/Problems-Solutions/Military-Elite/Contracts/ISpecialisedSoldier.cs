using Military_Elite.Models;
using System.Collections.Generic;

namespace Military_Elite.Contracts
{
    public interface ISpecialisedSoldier
    {
        List<Soldier> Marines { get; }

        List<Soldier> AirForces { get; }
    }
}
