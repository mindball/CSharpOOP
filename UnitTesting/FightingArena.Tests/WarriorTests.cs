using NUnit.Framework;
using System;

namespace Tests
{
    //using FightingArena;
    public class WarriorTests
    {
        [TestCase("MoonWarrior", 40, 100)]
        [TestCase("BloodWarrior", 50, 200)]
        [TestCase("SunshineWarrion", 55, 89)]
        [TestCase("SunRiseWarrior", 66, 86)]
        public void ConstructorInitialization(string name, int damage, int hp)
        {
            Warrior warrior = new Warrior(name, damage, hp);

            string expectedName = name;
            int expectedDamage = damage;
            int expectedHP = hp;

            string actualName = warrior.Name;
            int actualDamage = warrior.Damage;
            int actualHP = warrior.HP;

            Assert.AreEqual(expectedName, actualName);
            Assert.AreEqual(expectedDamage, actualDamage);
            Assert.AreEqual(expectedHP, actualHP);

        }

        [TestCase("")]
        [TestCase(null)]
        [TestCase(" ")]
        public void NameThrowArgumentExceptionWhenIsNullEmptyOrWhiteSpace(string name)
        {
            Assert.Throws<ArgumentException>(
                () => new Warrior(name, 1, 2));
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void DamageThrowArgumentExceptionWhenIsZeroOrNegativeNumber(int damage)
        {
            Assert.Throws<ArgumentException>(
                () => new Warrior("test", damage, 2));
        }

        [Test]
        public void HPThrowArgumentExceptionWhenIsNegativeNumber()
        {
            Assert.Throws<ArgumentException>(
                () => new Warrior("test", 2, -1
));
        }

        [TestCase("MoonWarrior", 400, 300)]
        //[TestCase("BloodWarrior", 100, 200)]
        //[TestCase("SunshineWarrion", 200, 500)]
        //[TestCase("SunRiseWarrior", 300, 100)]        
        public void AttackMethodWorkCorrectlyWhenAttackerIsMoreStrongThanDefender(string AttackerName, int AttackerDamage, int AttackerHp)
        {
            Warrior attacker = new Warrior(AttackerName, AttackerDamage, AttackerHp);

            string defenderName = "SopolWarrior";
            int defenderDamage = 100;
            int defenderHP = 50;
            Warrior defender = new Warrior(defenderName, defenderDamage, defenderHP);

            attacker.Attack(defender);

            int expectedAttackerHp = AttackerHp - defenderDamage;
            int actualAttackerHp = attacker.HP;

            Assert.AreEqual(expectedAttackerHp, actualAttackerHp);
        }

        [TestCase("SunshineWarrion", 200, 500)]
        public void AttackMethodWorkCorrectlyWhenAttackerDamageIsMoreThanDefenderHP
            (string AttackerName, int AttackerDamage, int AttackerHp)
        {
            Warrior attacker = new Warrior(AttackerName, AttackerDamage, AttackerHp);

            string defenderName = "SopolWarrior";
            int defenderDamage = 100;
            int defenderHP = 50;
            Warrior defender = new Warrior(defenderName, defenderDamage, defenderHP);

            attacker.Attack(defender);

            int expectedDefenderHp = 0;
            int actualDefenderHp = defender.HP;

            Assert.AreEqual(expectedDefenderHp, actualDefenderHp);
        }

        [TestCase("BloodWarrior", 100, 200)]
        public void AttackMethodWorkCorrectlyWhenDefenderHpIsMoreThanAttackerDamage(
            string attackerName, int attackerDamage, int attackerHp)
        {
            Warrior attacker = new Warrior(attackerName, attackerDamage, attackerHp);

            string defenderName = "SopolWarrior";
            int defenderDamage = 100;
            int defenderHP = 150;
            Warrior defender = new Warrior(defenderName, defenderDamage, defenderHP);

            attacker.Attack(defender);

            int expectedDefenderHp = defenderHP - attackerDamage;
            int actualDefenderHp = defender.HP;
        }

        [TestCase("FlabbyWarrior", 400, 30)]
        [TestCase("FlabbyWarrior", 400, 20)]

        public void AttackMethodShouldThrowInvalidOperationExceptionWhenAttackerHpIsLessOrEqual30(
            string attackerName, int attackerDamage, int attackerHp)
        {
            Warrior attacker = new Warrior(attackerName, attackerDamage, attackerHp);

            string defenderName = "SopolWarrior";
            int defenderDamage = 100;
            int defenderHP = 150;
            Warrior defender = new Warrior(defenderName, defenderDamage, defenderHP);

            Assert.Throws<InvalidOperationException>(
                () => attacker.Attack(defender));
        }

        [TestCase("FlabbyWarrior", 400, 30)]
        [TestCase("FlabbyWarrior", 400, 20)]

        public void AttackMethodShouldThrowInvalidOperationExceptionWhenDefenderHpIsLessOrEqual30(
            string defenderName, int defenderDamage, int defenderHp)
        {
            Warrior attacker = new Warrior("SunshineWarrion", 200, 500);
                       
            Warrior defender = new Warrior(defenderName, defenderDamage, defenderHp);

            Assert.Throws<InvalidOperationException>(
                () => attacker.Attack(defender));
        }


        public void AttackMethodShouldThrowInvalidOperationExceptionWhenAttackerHpIsLessThanDeffenderAttack()
        {
            int attackerHp = 100;
            int deffenderAttack = 101;
            Warrior attackWarrior = new Warrior("FireWarrior", 100, attackerHp);
            Warrior deffenderWarrior = new Warrior("WaterWarrior", deffenderAttack, 200);

            Assert.Throws<InvalidOperationException>(
                () => attackWarrior.Attack(deffenderWarrior));
        }
    }


    
}