using NUnit.Framework;
using System.Collections.Generic;
using System;

namespace Tests
{
    
    //using FightingArena;
    public class ArenaTests
    {
        private Warrior testWarrior;
        private Arena newArena;

        [SetUp]
        public void Setup()
        {
            testWarrior = new Warrior("testWarrior", 50, 80);
            newArena = new Arena();
        }

        [Test]
        public void ArenaCollectionOfWarriorsWorkCorrectyly()
        {
            List<Warrior> expectedWarriors = new List<Warrior>();
            CollectionAssert.AreEqual(expectedWarriors, newArena.Warriors);
        }

        [Test]
        public void EnrollMethodWorkCorrectly()
        {
            List<Warrior> expectedWarriors = new List<Warrior>() { testWarrior };
            newArena.Enroll(testWarrior);

            CollectionAssert.AreEqual(expectedWarriors, newArena.Warriors);
        }

        [Test]
        public void EnrollMethodShouldThrowInvalidOperationExceptionWhenNameOfWarriorIsDuplicated()
        {
            newArena.Enroll(testWarrior);
            Assert.Throws<InvalidOperationException>(
                () => newArena.Enroll(testWarrior));
        }

        [Test]
        public void CountPropertyWorkCorrectlyWhenEnrolMethodWorkCorrectly()
        {
            newArena.Enroll(testWarrior);
            List<Warrior> expectedWarriors = new List<Warrior>() { testWarrior };

            int expectedCount = expectedWarriors.Count;
            int actualCount = newArena.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void WarriorsCollectionTestForCorrectnessWhenAddingMoreThanOneWarrior()
        {
            Warrior newWarrior = new Warrior("Bahrturabaduba", 45, 100);

            newArena.Enroll(testWarrior);
            newArena.Enroll(newWarrior);

            List<Warrior> expectedWarriors = new List<Warrior>()
            {
                testWarrior,
                newWarrior
            };

            CollectionAssert.AreEqual(expectedWarriors, newArena.Warriors);
        }

        
        [Test]
        public void FightMethodShouldDecreaseAttackerHpWhenAttackDefender()
        {
            Warrior deffenderWarrior = new Warrior("defend", 40, 60);
            newArena.Enroll(testWarrior);
            newArena.Enroll(deffenderWarrior);

            newArena.Fight(testWarrior.Name, deffenderWarrior.Name);

            int expectedValue = 40;
            int actualValue = testWarrior.HP;

            Assert.AreEqual(expectedValue, actualValue);
        }

        [Test]
        public void FightMethodShouldDecreaseDefenderHpWhenIsAttack()
        {
            Warrior deffenderWarrior = new Warrior("defend", 40, 60);
            newArena.Enroll(testWarrior);
            newArena.Enroll(deffenderWarrior);

            newArena.Fight(testWarrior.Name, deffenderWarrior.Name);

            int expectedValue = 10;
            int actualValue = deffenderWarrior.HP;

            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestCase("", "BloodWarrior")]
        [TestCase(" ", "BloodWarrior")]
        [TestCase(null, "MoonWarrior")]
        [TestCase("NotFoundWarriorInCollection", "MoonWarrior")]
        [TestCase("BloodWarrior", "")]
        [TestCase("BloodWarrior", " ")]
        [TestCase("MoonWarrior", null)]
        [TestCase("MoonWarrior", "NotFoundWarriorInCollection")]
        [TestCase("NotFoundWarriorInCollection", "NotFoundWarriorInCollection2")]
        public void FightMethodThrowInvalidOperationExceptionWhenWarriorIsNotInTheCollection(
            string nameOne, string nameTwo)
        {            
            Warrior attackerWarrior1 = new Warrior("BloodWarrior", 50, 60);
            Warrior attackerWarrior2 = new Warrior("MoonWarrior", 60, 100);

            newArena.Enroll(attackerWarrior1);
            newArena.Enroll(attackerWarrior2);
            newArena.Enroll(testWarrior);

            Assert.Throws<InvalidOperationException>(
                () => newArena.Fight(nameOne, nameTwo));
        }

    }
}
