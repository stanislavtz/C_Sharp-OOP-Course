using Inferno_Infinity.Weapons.Contracts;

namespace Inferno_Infinity.WeaponRarities
{
    public class Uncommon
    {
        private const int CHANGE_COEFICIENT = 2;

        private readonly IWeapon weapon;

        public Uncommon(IWeapon weapon)
        {
            this.weapon = weapon;
            this.IncreaseDamage();
        }

        private IWeapon IncreaseDamage()
        {
            this.weapon.MinDamage *= CHANGE_COEFICIENT;
            this.weapon.MaxDamage *= CHANGE_COEFICIENT;

            return this.weapon;
        }
    }
}
