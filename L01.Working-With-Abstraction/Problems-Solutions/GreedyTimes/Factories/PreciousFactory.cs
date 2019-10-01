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
                precious = new Gold(typeOfPreciouse, qtty);
            }
            else if (typePR.EndsWith("gem"))
            {
                precious = new Gem(typeOfPreciouse, qtty);
            }
            else if (typePR.Length == 3)
            {
                precious = new Cash(typeOfPreciouse, qtty);
            }

            return precious;
        }
    }
}
