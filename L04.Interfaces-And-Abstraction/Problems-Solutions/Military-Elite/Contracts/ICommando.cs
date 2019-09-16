using System.Collections.Generic;

namespace Military_Elite
{
    public interface ICommando
    {
        Dictionary<string, string> Missions { get; }

        void CompleteMission();
    }
}
