﻿using System;
using Military_Elite.Contracts;

namespace Military_Elite.Models
{
    public class Private : Soldier, IPrivate
    {
        public decimal Salary => throw new NotImplementedException();
    }
}
