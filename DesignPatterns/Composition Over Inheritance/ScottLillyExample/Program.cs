using ScottLillyExample.Composition_Before;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScottLillyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Monster newMonster = MonsterFactory.CreateMonster(MonsterType.Horse);
            Monster new1Monster = MonsterFactory.CreateMonster(MonsterType.Kangaroo);
            Monster new2Monster = MonsterFactory.CreateMonster(MonsterType.Orc);
        }
    }
}
