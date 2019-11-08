using Inferno_Infinity.Gems.Models;
using Inferno_Infinity.Weapons.Contracts;

namespace Inferno_Infinity.Gems
{
    public class Ruby : Gem
    {
        private readonly int strenghtCoieficient = 7;
        private readonly int agilityCoeficient = 2;
        private readonly int vitalityCoeficient = 5;

        public Ruby()
        {
            this.StrenghtIncreaseValue = this.strenghtCoieficient;
            this.AgilityIncreaseValue = this.agilityCoeficient;
            this.VitalityIncreaseValue = this.vitalityCoeficient;
        }

        public override void IncreaseWeaponMagicStats(IWeapon weapon)
        {
            weapon.Strength = this.StrenghtIncreaseValue;
            weapon.Agility = this.AgilityIncreaseValue;
            weapon.Vitality = this.VitalityIncreaseValue;

            weapon.MaxDamage += (weapon.Strength * 3 + weapon.Agility * 4);
            weapon.MinDamage += (weapon.Strength * 2 + weapon.Agility * 1);
        }
    }
}
