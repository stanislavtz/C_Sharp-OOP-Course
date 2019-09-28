using P04_Hospital.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace P04_Hospital.Models
{
    public class Department : IDepartment
    {
        private const int ROOMS_NUMBER = 20;

        public Department(string name)
        {
            this.Name = name;

            this.PaitientsInDepartment = new List<IPatient>();
        }

        public int Rooms_Number => ROOMS_NUMBER;

        public string Name { get; private set; }

        public IList<IPatient> PaitientsInDepartment { get; }
    }
}
