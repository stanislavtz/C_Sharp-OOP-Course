using Military_Elite.Contracts;
using System;
using System.Collections.Generic;

namespace Military_Elite.Models
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public string Corps => throw new NotImplementedException();

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + $"Corps: {this.Corps}";
        }
    }
}
