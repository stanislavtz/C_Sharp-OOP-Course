using System;
using System.Collections.Generic;
using System.Text;

namespace P04_Hospital.Models.Contracts
{
    public interface IDepartment
    {
        int Rooms_Number { get; }

        IList<IPatient> PaitientsInDepartment { get; }
    }
}
