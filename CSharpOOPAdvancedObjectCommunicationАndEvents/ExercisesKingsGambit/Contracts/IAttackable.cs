using System;
using System.Collections.Generic;
using System.Text;

namespace ExercisesKingsGambit.Contracts
{
    public delegate void AttackKingEventHadler();
    public interface IAttackable
    {
        event AttackKingEventHadler AttackTheKing;

        void GetAttack();
    }
}
