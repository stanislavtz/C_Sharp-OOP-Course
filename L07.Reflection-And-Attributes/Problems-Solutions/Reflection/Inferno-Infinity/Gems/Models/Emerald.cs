﻿using Inferno_Infinity.Gems.Models;
using Inferno_Infinity.Weapons.Contracts;

namespace Inferno_Infinity.Gems
{
    public class Emerald : Gem
    {
        private readonly int strenghtCoieficient = 1;
        private readonly int agilityCoeficient = 4;
        private readonly int vitalityCoeficient = 9;

        private int maxDamegeIncreaseValue;
        private int minDamegeIncreaseValue;

        public Emerald()
        {
            this.StrenghtIncreaseValue = this.strenghtCoieficient;
            this.AgilityIncreaseValue = this.agilityCoeficient;
            this.VitalityIncreaseValue = this.vitalityCoeficient;
        }

        public override void IncreaseWeaponMagicStats(IWeapon weapon)
        {
            this.maxDamegeIncreaseValue = weapon.Strength * 3 + weapon.Agility * 4;
            this.minDamegeIncreaseValue = weapon.Strength * 2 + weapon.Agility * 1;

            weapon.Strength = this.StrenghtIncreaseValue;
            weapon.Agility = this.AgilityIncreaseValue;
            weapon.Vitality = this.VitalityIncreaseValue;

            weapon.MaxDamage += this.maxDamegeIncreaseValue;
            weapon.MinDamage += this.minDamegeIncreaseValue;
        }
    }
}
