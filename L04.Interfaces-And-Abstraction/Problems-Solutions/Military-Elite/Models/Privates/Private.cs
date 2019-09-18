﻿using Military_Elite.Contracts;

namespace Military_Elite.Models
{
    public class Private : Soldier, IPrivate
    {
        public Private(string id, string firstName, string lastName, decimal salary) 
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
        }

        public decimal Salary { get; }

        public override string ToString() =>
            $"{base.ToString()} Salary: {this.Salary:f2}";
    }
}
