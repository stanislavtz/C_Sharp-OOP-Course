using System.Collections.Generic;

namespace P04_Hospital.Models
{
    public class Doctror : Person
    {
        private readonly List<Patient> patientsList;

        public Doctror(string name) 
            : base(name)
        {
            this.patientsList = new List<Patient>();
        }

        public IReadOnlyCollection<Patient> PatientList => this.patientsList;

        public void AddPatient(Patient patient)
        {
            patientsList.Add(patient);
        }
    }
}