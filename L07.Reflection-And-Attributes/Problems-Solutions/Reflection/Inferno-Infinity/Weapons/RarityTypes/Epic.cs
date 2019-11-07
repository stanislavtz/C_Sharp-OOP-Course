using Inferno_Infinity.Weapons.Contracts;

namespace Inferno_Infinity.WeaponRarities
{
    public class Epic
    {
        private const int CHANGE_COEFICIENT = 5;

        private IWeapon weapon;

        public Epic(IWeapon weapon)
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
