﻿namespace Military_Elite.Contracts.SpecialForces
{
    public interface IRepair
    {
        string PartName { get; }

        int WorkedHours { get; }
    }
}
