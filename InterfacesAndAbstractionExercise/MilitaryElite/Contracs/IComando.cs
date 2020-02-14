using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Contracs
{
    public interface IComando : ISpecialisedSoldier
    {
        IReadOnlyCollection<IMission> Missions { get; }

        void AddMission(IMission mission);
    }
}
