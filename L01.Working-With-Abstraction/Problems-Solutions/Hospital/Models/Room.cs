using System.Collections.Generic;

namespace P04_Hospital.Models
{
    public  class Room
    {
        private List<Patient> patients;

        public Room()
        {
            this.patients = new List<Patient>();
        }

        public IReadOnlyList<Patient> PatientsInRoom => this.patients;

        public void AddPatient(Patient patient)
        {
            patients.Add(patient);
        }
    }
}
