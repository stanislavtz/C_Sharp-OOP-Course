using P04_Hospital.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace P04_Hospital.Models
{
    public class Room : IRoom
    {
        public Room()
        {
            PatientsInRoom = new List<IPatient>();
        }

        public IList<IPatient> PatientsInRoom { get; }
    }
}
