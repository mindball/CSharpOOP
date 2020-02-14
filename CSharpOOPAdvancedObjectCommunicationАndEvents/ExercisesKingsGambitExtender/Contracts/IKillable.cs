using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesKingsGambitExtended.Contracts
{
    public interface IKillable
    {
        bool IsAlive { get; }
       int HitPoints { get; }
        void TakeDamage();
        void Kill();
    }
}
