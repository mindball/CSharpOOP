using System.Collections.Generic;

namespace MilitaryEliteVersion2.Contracts
{
    public interface ICommando : ISpecialisedSoldier
    {
        IReadOnlyCollection<IMission> Missions { get; }

        void AddMission(IMission missionCodeName);
    }
}
