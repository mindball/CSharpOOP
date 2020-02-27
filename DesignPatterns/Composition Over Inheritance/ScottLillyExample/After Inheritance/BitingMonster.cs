using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScottLillyExample.After_Inheritance
{
    public class BitingMonster : Monster
    {
        public int BiteDamage { get; set; }

        public BitingMonster(int hitPoints, int biteDamage)
            : base(hitPoints)
        {
            BiteDamage = biteDamage;
        }
    }
}
