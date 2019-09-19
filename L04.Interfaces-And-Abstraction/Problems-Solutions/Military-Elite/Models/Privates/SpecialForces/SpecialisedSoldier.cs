using System;
using System.Collections.Generic;
using Military_Elite.Contracts;
using Military_Elite.Exceptions;

namespace Military_Elite.Models
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        private string corps;
        private List<string> corpses;

        public SpecialisedSoldier(string id, string firstName, string lastName, decimal salary, string corps) 
            : base(id, firstName, lastName, salary)
        {
            corpses = new List<string>();

            ParseCorpses();

            this.Corps = corps;
        }

        public string Corps
        {
            get => this.corps;
            private set
            {
                if (!corpses.Contains(value))
                {
                    throw new InvalidCorpsException();
                }

                this.corps = value;
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()} {Environment.NewLine}Corps: {this.Corps}";
        }

        private void ParseCorpses()
        {
            corpses.Add("Airforces");
            corpses.Add("Marines");
        }
    }
}
