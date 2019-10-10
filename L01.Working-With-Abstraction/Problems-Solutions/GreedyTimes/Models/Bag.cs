using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P05_GreedyTimes.Models
{
    public class Bag
    {
        private List<IPrecious> bagContent;

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
            }
            else
            {
                return;
            }

            if (preciousType == "Gold")
            {
                bool canAddGold = this.totalGoldQtty + precious.Quantity <= this.Capacity;

                if (canAddGold)
                {
                    this.bagContent.Add(precious);
                    this.totalGoldQtty += precious.Quantity;
                    this.Capacity -= precious.Quantity;
                }
            }
            else if (this.preciousType.ToLower().EndsWith("gem"))
            {
                bool canAddGems = this.totalGemsQtty + precious.Quantity <= this.totalGoldQtty;

                if (canAddGems)
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

                    this.totalGemsQtty += precious.Quantity;
                    this.Capacity -= precious.Quantity;
                }
            }
            else if (this.preciousType.Length == 3)
            {
                bool canAddCash = this.totalCashQtty + precious.Quantity <= this.totalGemsQtty;

                if (canAddCash)
                {
                    var serachedPrecious = bagContent.FirstOrDefault(p => p.PreciousType == this.preciousType);

                    if (serachedPrecious == null)
                    {
                        this.bagContent.Add(precious);
                    }
                    else
                    {
                        serachedPrecious.Quantity += precious.Quantity;
                    }

                    this.totalCashQtty += precious.Quantity;
                    this.Capacity -= precious.Quantity;
                }
            }
        }

        public override string ToString()
        {

            IPrecious[] goldCollection = this.bagContent
                .Where(b => b.PreciousType == "Gold")
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
                sb.AppendLine($"<Gold> ${totalGoldQtty}")
                    .AppendLine($"##Gold - {totalGoldQtty}");
            }

            if (totalGemsQtty > 0)
            {
                sb.AppendLine($"<Gem> ${totalGemsQtty}");
                foreach (var item in gemsCollection)
                {
                    sb.AppendLine($"##{item.PreciousType} - {item.Quantity}");
                }
            }

            if (totalCashQtty > 0)
            {
                sb.AppendLine($"<Cash> ${totalCashQtty}");
                foreach (var item in cashCollection)
                {
                    sb.AppendLine($"##{item.PreciousType} - {item.Quantity}");
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}
