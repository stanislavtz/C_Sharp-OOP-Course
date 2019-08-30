using System;
using System.Collections.Generic;
using System.Text;

namespace P04_Hospital.Models.Contracts
{
    public interface IDoctor
    {
        IList<IPatient> DoctorPatients { get; }
    }
}
