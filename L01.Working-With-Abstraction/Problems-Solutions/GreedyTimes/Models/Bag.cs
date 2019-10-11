using System.Linq;
using System.Text;

using System.Collections.Generic;

namespace P05_GreedyTimes.Models
{
    public class Bag
    {
        private readonly List<IPrecious> bagContent;

        private long totalGoldQtty = 0;
        private long totalGemsQtty = 0;
        private long totalCashQtty = 0;

        private string preciousType;

        public Bag(long capacity)
        {
            this.Capacity = capacity;

            this.bagContent = new List<IPrecious>();
        }

        public long Capacity { get; private set; }

        public void AddPrecious(IPrecious precious)
        {
            if (precious != null)
            {
                this.preciousType = precious.PreciousType;
                if (preciousType.ToLower() == "gold")
                {
                    bool canAddGol = this.totalGoldQtty + precious.Quantity <= this.Capacity;

                    if (canAddGol)
                    {
                        this.totalGoldQtty  = AddCurrentPrrecious(precious, this.totalGoldQtty);
                    }
                }
                else if (this.preciousType.ToLower().EndsWith("gem"))
                {
                    bool canAddGems = this.totalGemsQtty + precious.Quantity <= this.totalGoldQtty;

                    if (canAddGems)
                    {
                        this.totalGemsQtty = AddCurrentPrrecious(precious, this.totalGemsQtty);
                    }
                }
                else if (this.preciousType.ToLower().Length == 3)
                {
                    bool canAddCash = this.totalCashQtty + precious.Quantity <= this.totalGemsQtty;

                    if (canAddCash)
                    {
                        this.totalCashQtty = AddCurrentPrrecious(precious, this.totalCashQtty);
                    }
                }
            }
        }

        public override string ToString()
        {

            IPrecious[] goldCollection = this.bagContent
                .Where(b => b.PreciousType.ToLower() == "gold")
                .OrderByDescending(b => b.PreciousType)
                .ThenBy(b => b.Quantity)
                .ToArray();

            IPrecious[] gemsCollection = this.bagContent
                .Where(b => b.PreciousType.ToLower().EndsWith("gem"))
                .OrderByDescending(b => b.PreciousType)
                .ThenBy(b => b.Quantity)
                .ToArray();

            IPrecious[] cashCollection = this.bagContent
                .Where(b => b.PreciousType.Length == 3)
                .OrderByDescending(b => b.PreciousType)
                .ThenBy(b => b.Quantity)
                .ToArray();

            StringBuilder sb = new StringBuilder();

            if (totalGoldQtty > 0)
            {
                AppendPrecious(goldCollection, sb, totalGoldQtty);
            }

            if (totalGemsQtty > 0)
            {
                AppendPrecious(gemsCollection, sb, totalGemsQtty);
            }

            if (totalCashQtty > 0)
            {
                AppendPrecious(cashCollection, sb, totalCashQtty);
            }

            return sb.ToString().TrimEnd();
        }

        private long AddCurrentPrrecious(IPrecious precious, long totalPreciousQtty)
        {
            var serachedPrecious = bagContent.FirstOrDefault(p => p.PreciousType.ToLower() == this.preciousType.ToLower());

            if (serachedPrecious == null)
            {
                this.bagContent.Add(precious);
            }
            else
            {
                serachedPrecious.Quantity += precious.Quantity;
            }

            totalPreciousQtty += precious.Quantity;
            this.Capacity -= precious.Quantity;

            return totalPreciousQtty;
        }

        private void AppendPrecious(IPrecious[] collection, StringBuilder sb, long totalPreciosQtty)
        {
            var precious = collection[0].GetType().Name;

            sb.AppendLine($"<{precious}> ${totalPreciosQtty}");
            foreach (var item in collection)
            {
                sb.AppendLine($"##{item.PreciousType} - {item.Quantity}");
            }
        }
    }
}
