using Inferno_Infinity.Weapons.Contracts;

namespace Inferno_Infinity.WeaponRarities
{
    public class Rare
    {
        private const int CHANGE_COEFICIENT = 3;

        private IWeapon weapon;

        public Rare(IWeapon weapon)
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
