using System.Linq;
using P05_GreedyTimes.Models;

namespace P05_GreedyTimes.Factories
{
    public class PreciousFactory
    {
        private Precious precious;

        public Precious CreatePrecious(string typeOfPreciouse, int qtty)
        {
            string typePR = typeOfPreciouse.ToLower();

            if (typePR == "gold")
            {
                precious = new Gold(qtty);
            }
            else if (typePR.EndsWith("gem"))
            {
                precious = new Gem(qtty);
            }
            else if (typePR.Length == 3 && typePR.All(ch => char.IsUpper(ch)))
            {
                precious = new Cash(qtty);
            }

            return precious;
        }
    }
}
