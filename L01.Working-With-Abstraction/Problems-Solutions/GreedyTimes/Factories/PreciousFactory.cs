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
                precious = new Gold(typeOfPrecious, qtty);
            }
            else if (typePR.EndsWith("gem"))
            {
                precious = new Gem(typeOfPrecious, qtty);
            }
            else if (typePR.Length == 3)
            {
                precious = new Cash(typeOfPrecious, qtty);
            }

            return precious;
        }
    }
}
