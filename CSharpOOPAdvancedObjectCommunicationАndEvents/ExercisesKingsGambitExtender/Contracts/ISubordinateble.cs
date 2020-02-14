using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesKingsGambitExtended.Contracts
{
    public delegate void SubordinateDeathEventHandler(object sender);
    public interface ISubordinateble : INameble, IKillable
    {
        event SubordinateDeathEventHandler RemoveDeathUnitEvent;
        string Action { get; }
        void ReactOnAttack();

    }
}
