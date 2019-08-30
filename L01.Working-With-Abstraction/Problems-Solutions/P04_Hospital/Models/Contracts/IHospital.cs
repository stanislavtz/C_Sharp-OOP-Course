﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P04_Hospital.Models.Contracts
{
    public interface IHospital
    {
        IList<IDepartment> Depatments { get; }
        IList<IDoctor> Doctors { get; }
    }
}
