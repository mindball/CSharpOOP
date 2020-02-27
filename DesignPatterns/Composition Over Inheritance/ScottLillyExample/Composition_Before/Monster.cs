using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScottLillyExample.Composition_Before
{
    public class Monster
    {
        public enum AttackType
        {
            None = 0,
            Biting = 1,
            Kicking = 2,
            Punching = 3
        }

        public Monster(int hitPoints)
        {
            this.HitPoints = hitPoints;
            this.AttackTypes = new Dictionary<AttackType, int>();
        }

        public int HitPoints { get; set; }
        public Dictionary<AttackType, int> AttackTypes { get; set; }

        // These replace the functionality of checking an object's "type",
        // to see if it "is" a certain datatype (KickingMonster, BitingMonster, etc.)
        public bool CanBite => this.AttackTypes.ContainsKey(AttackType.Biting);
        public bool CanKick => this.AttackTypes.ContainsKey(AttackType.Kicking);
        public bool CanPunch => this.AttackTypes.ContainsKey(AttackType.Punching);

        public int BiteDamage
        {
            get
            {
                if(this.CanBite)
                {
                    return this.AttackTypes[AttackType.Biting];
                }

                throw new NotSupportedException("This monster cannot bite.");
            }
        }

        public int KickDamage
        {
            get
            {
                if (this.CanKick)
                {
                    return this.AttackTypes[AttackType.Kicking];
                }

                throw new NotSupportedException("This monster cannot kick.");
            }
        }

        public int PunchDamage
        {
            get
            {
                if (this.CanPunch)
                {
                    return this.AttackTypes[AttackType.Punching];
                }

                throw new NotSupportedException("This monster cannot punch.");
            }
        }

        public void AddAttackType(AttackType attackType, int amountOfDamage)
        {
           this.AttackTypes[attackType] = amountOfDamage;
        }
    }
}
