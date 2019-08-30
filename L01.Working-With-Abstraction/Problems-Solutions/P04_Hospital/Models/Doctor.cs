using P04_Hospital.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace P04_Hospital.Models
{
    public class Doctor : IDoctor
    {
        public Doctor(string fullName)
        {
            this.FullName = fullName;

            this.DoctorPatients = new List<IPatient>();
        }

        public string FullName { get; private set; }

        public IList<IPatient> DoctorPatients { get; }
    }
}
