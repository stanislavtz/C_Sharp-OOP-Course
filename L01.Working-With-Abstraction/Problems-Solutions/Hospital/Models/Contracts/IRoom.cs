using System.Collections.Generic;

namespace P04_Hospital.Models.Contracts
{
    public interface IRoom
    {
        IList<IPatient> PatientsInRoom { get; }
    }
}
