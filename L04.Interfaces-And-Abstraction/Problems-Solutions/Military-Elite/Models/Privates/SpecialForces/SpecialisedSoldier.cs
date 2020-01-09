using System;
using Military_Elite.Contracts;
using Military_Elite.Enumerators;
using Military_Elite.Exceptions;

namespace Military_Elite.Models
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(string id, string firstName, string lastName, decimal salary, string corps)
        : base(id, firstName, lastName, salary)
        {
            ParseCorps(corps);
        }

        public Corps Corps { get; private set; }

        public override string ToString()
        {
            return $"{base.ToString()}{Environment.NewLine}Corps: {this.Corps}";
        }

        private void ParseCorps(string corpsStr)
        {
            Corps corps;

            bool parsed = Enum.TryParse<Corps>(corpsStr, out corps);

            if (!parsed)
            {
                throw new InvalidCorpsException();
            }

            this.Corps = corps;
        }
    }
}
