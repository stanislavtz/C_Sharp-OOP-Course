namespace Inferno_Infinity.Weapons.Models
{
    public class Knife : Weapon
    {
        private const int MIN_DAMAGE = 3;
        private const int MAX_DAMAGE = 4;
        private const int NUM_SOCKETS = 2;

        public Knife(string name)
            : base(name, MIN_DAMAGE, MAX_DAMAGE, NUM_SOCKETS)
        {
        }
    }
}
