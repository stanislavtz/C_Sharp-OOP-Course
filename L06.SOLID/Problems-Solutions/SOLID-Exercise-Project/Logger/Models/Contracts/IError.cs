﻿using Logger.Models.Enumarations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Models.Contracts
{
    public interface IError
    {
        DateTime Datetime { get; }

        Level Level { get; }

        string Message { get; }
    }
}
