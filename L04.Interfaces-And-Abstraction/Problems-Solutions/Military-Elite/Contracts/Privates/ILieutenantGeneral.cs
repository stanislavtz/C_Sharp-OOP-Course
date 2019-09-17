﻿using Military_Elite.Models;
using System.Collections.Generic;

namespace Military_Elite.Contracts
{
    public interface ILieutenantGeneral
    {
        IReadOnlyCollection<Private> Privates { get; }
    }
}
