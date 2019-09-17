using System.Collections.Generic;

namespace Military_Elite
{
    public interface ICommando
    {
        IReadOnlyCollection<Mission> Missions { get; }

        void CompleteMission(string codeName);
    }
}
