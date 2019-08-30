using System;
using System.Collections.Generic;
using System.Text;

namespace P04_Hospital.Models.Contracts
{
    public class Patient : IPatient
    {
        public Patient(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}