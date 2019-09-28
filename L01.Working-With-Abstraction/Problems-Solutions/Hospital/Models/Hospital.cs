using P04_Hospital.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace P04_Hospital.Models
{
    public class Hospital : IHospital
    {
        public Hospital()
        {
            this.Depatments = new List<Department>();

            this.Doctors = new List<Doctor>();
        }

        public IList<Department> Depatments { get; }

        public IList<Doctor> Doctors { get; }
    }
}
