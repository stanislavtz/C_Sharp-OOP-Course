﻿namespace Inferno_Infinity.Weapons.Contracts
{
    public interface IWeapon
    {
        string Name { get; }

        int MinDamage { get; set; }
        int MaxDamage { get; set; }
        int NumSockets { get; }

        int Strength { get; set; }
        int Agility { get; set; }
        int Vitality { get; set; }
    }
}
