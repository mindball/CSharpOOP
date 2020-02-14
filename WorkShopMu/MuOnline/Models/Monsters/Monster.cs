namespace MuOnline.Models.Monsters
{
    using System;
    using Contracts;

    using MuOnline.Utilities.Models;

    public abstract class Monster : IMonster
    {
        private int attackPoints;
        private int vitalityPoints;

        public Monster(int attackPoints, int vitalityPoints)
        {
            this.AttackPoints = attackPoints;
            this.VitalityPoints = vitalityPoints;
        }

        public int AttackPoints
        {
            get
            {
                return this.attackPoints;
            }
            private set
            {
                MonsterValidator.ValidHero(nameof(this.AttackPoints), value);
                this.attackPoints = value;
            }
        }

        public int VitalityPoints
        {
            get
            {
                return this.vitalityPoints;
            }
            private set
            {
                MonsterValidator.ValidHero(nameof(this.AttackPoints), value);
                this.vitalityPoints = value;
            }
        }

        public bool IsAlive
            => this.VitalityPoints > 0;

        public int TakeDamage(int attackPoints)
        {
            if (!this.IsAlive)
            {
                return 0;
            }

            var exp = Math.Abs(this.VitalityPoints - attackPoints);

            return exp;
        }
    }
}
