using Military_Elite.Contracts;
using System.Collections.Generic;

namespace Military_Elite
{
    public interface IEngineer : ISpecialisedSoldier
    {
        Dictionary<string, int> Repairs { get; }
    }
}
