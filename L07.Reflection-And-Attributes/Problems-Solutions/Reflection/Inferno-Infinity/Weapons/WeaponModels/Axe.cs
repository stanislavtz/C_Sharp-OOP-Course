namespace Inferno_Infinity.Weapons.Models
{
    public class Axe : Weapon
    {
        private const int MIN_DAMAGE = 5;
        private const int MAX_DAMAGE = 10;
        private const int NUM_SOCKETS = 4;

        public Axe(string name) 
            : base(name, MIN_DAMAGE, MAX_DAMAGE, NUM_SOCKETS)
        {
        }
    }
}
