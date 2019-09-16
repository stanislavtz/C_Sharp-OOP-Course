using Military_Elite.Contracts;
using System;
using System.Collections.Generic;

namespace Military_Elite.Models
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(string id, string firstName, string lastName, decimal salary, string corps) 
            : base(id, firstName, lastName, salary)
        {
            this.Corps = corps;
        }

        public string Corps { get; private set; }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + $"Corps: {this.Corps}";
        }
    }
}
