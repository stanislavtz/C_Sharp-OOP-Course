using P05_GreedyTimes.Models;

namespace P05_GreedyTimes.Factories
{
    public class PreciousFactory
    {
        private IPrecious precious;

        public IPrecious CreatePrecious(string typeOfPrecious, int qtty)
        {
            string typePR = typeOfPrecious.ToLower();

            if (typePR == "gold")
            {
                precious = new Gold(typePR, qtty);
            }
            else if (typePR.EndsWith("gem"))
            {
                precious = new Gem(typePR, qtty);
            }
            else if (typePR.Length == 3)
            {
                precious = new Cash(typePR, qtty);
            }

            return precious;
        }
    }
}
