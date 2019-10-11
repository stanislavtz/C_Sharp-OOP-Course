using P05_GreedyTimes.Models;

namespace P05_GreedyTimes.Factories
{
    public class PreciousFactory
    {
        private IPrecious precious;

        public IPrecious CreatePrecious(string preciousType, long qtty)
        {
            string typePR = preciousType.ToLower();
            
            if (typePR == "gold")
            {
                precious = new Gold(preciousType, qtty);
            }
            else if (typePR.EndsWith("gem"))
            {
                precious = new Gem(preciousType, qtty);
            }
            else if (typePR.Length == 3)
            {
                precious = new Cash(preciousType, qtty);
            }
            else
            {
                return null;
            }

            return precious;
        }
    }
}
