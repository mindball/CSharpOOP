﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScottLillyExample.Composition_Before
{
    public class MonsterFactory
    {       
        public static Monster CreateMonster(MonsterType monsterType)
        {
            Monster monster;

            switch (monsterType)
            {
                case MonsterType.Horse:
                    monster = new Monster(10);
                    monster.AddAttackType(Monster.AttackType.Biting, 5);
                    monster.AddAttackType(Monster.AttackType.Kicking, 5);
                    break;
                case MonsterType.Orc:
                    monster = new Monster(10);
                    monster.AddAttackType(Monster.AttackType.Biting, 5);
                    monster.AddAttackType(Monster.AttackType.Kicking, 5);
                    monster.AddAttackType(Monster.AttackType.Punching, 5);
                    break;
                case MonsterType.Crocodile:
                    monster = new Monster(10);
                    monster.AddAttackType(Monster.AttackType.Biting, 5);
                    break;
                case MonsterType.MikeTyson:
                    monster = new Monster(10);
                    monster.AddAttackType(Monster.AttackType.Biting, 5);
                    monster.AddAttackType(Monster.AttackType.Punching, 5);
                    break;
                case MonsterType.Camel:
                    monster = new Monster(10);
                    monster.AddAttackType(Monster.AttackType.Kicking, 5);
                    break;
                case MonsterType.Kangaroo:
                    monster = new Monster(10);
                    monster.AddAttackType(Monster.AttackType.Kicking, 5);
                    monster.AddAttackType(Monster.AttackType.Punching, 5);
                    break;
                case MonsterType.MantisShrimp:
                    monster = new Monster(10);
                    monster.AddAttackType(Monster.AttackType.Punching, 5);
                    break;
                default:
                    throw new ArgumentException();
            }
            return monster;
        }

        }
}
