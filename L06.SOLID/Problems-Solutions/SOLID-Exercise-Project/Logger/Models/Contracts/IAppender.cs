using Logger.Models.Enumarations;

namespace Logger.Models.Contracts
{
    public interface IAppender
    {
        ILayout Layout { get; }

        Level Level { get; }

        void Append();
    }
}
