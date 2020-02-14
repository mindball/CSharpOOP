using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesKingsGambit.Contracts
{
    public interface IKillable
    {
        bool IsAlive { get; }

        void Kill();
    }
}
