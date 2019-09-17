using Military_Elite.Contracts;
using System;
using System.Collections.Generic;

namespace Military_Elite.Models
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        private string corps;
        private List<string> specialForces;

        public SpecialisedSoldier(string id, string firstName, string lastName, decimal salary, string corps)
            : base(id, firstName, lastName, salary)
        {
            this.Corps = corps;
            specialForces = new List<string>();
        }

        public string Corps
        {
            get => this.corps;
            private set
            {

                if (!specialForces.Contains(value))
                {
                    throw new ArgumentException("Invalid Corps!");
                }

                this.corps = value;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()} {Environment.NewLine} Corps: {this.Corps}";
        }

        private void AddCorps()
        {
            specialForces.Add("Airforces");
            specialForces.Add("Marines");
        }
    }
}
