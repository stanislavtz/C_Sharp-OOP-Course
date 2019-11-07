namespace Inferno_Infinity.Weapons.Models
{
    public class Sword : Weapon
    {
        private const int MIN_DAMAGE = 4;
        private const int MAX_DAMAGE = 6;
        private const int NUM_SOCKETS = 3;

        public Sword(string name)
            : base(name, MIN_DAMAGE, MAX_DAMAGE, NUM_SOCKETS)
        {
        }
    }
}
