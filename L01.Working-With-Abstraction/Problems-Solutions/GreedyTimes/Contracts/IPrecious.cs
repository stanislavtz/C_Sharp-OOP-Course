namespace P05_GreedyTimes.Models
{
    public interface IPrecious
    {
        string PreciousType { get; }

        long Quantity { get; set; }
    }
}
