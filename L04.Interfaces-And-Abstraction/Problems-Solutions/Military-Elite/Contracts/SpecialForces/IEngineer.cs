using Military_Elite.Contracts;
using System.Collections.Generic;

namespace Military_Elite
{
    public interface IEngineer 
    {
        IReadOnlyCollection<Repair> Repairs { get; }
    }
}
