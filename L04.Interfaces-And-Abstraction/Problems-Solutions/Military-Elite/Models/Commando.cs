using System;
using System.Collections.Generic;

namespace Military_Elite.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public override List<Soldier> Marines => throw new NotImplementedException();

        public override List<Soldier> AirForces => throw new NotImplementedException();

        public Dictionary<string, string> Missions => throw new NotImplementedException();

        public void CompleteMission()
        {
            throw new NotImplementedException();
        }
    }
}
