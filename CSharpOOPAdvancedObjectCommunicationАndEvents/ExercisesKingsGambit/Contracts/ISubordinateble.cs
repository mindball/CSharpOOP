using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesKingsGambit.Contracts
{
    public interface ISubordinateble : INameble, IKillable
    {
        string Action { get; }
        void ReactOnAttack();
    }
}
