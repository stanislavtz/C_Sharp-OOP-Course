using System;
using System.Collections.Generic;

namespace Military_Elite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public override List<Soldier> Marines => throw new NotImplementedException();

        public override List<Soldier> AirForces => throw new NotImplementedException();

        public Dictionary<string, int> Repairs => throw new NotImplementedException();
    }
}
