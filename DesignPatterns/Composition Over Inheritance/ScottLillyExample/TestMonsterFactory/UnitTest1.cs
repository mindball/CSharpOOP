using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScottLillyExample.After_Inheritance;

namespace TestMonsterFactory
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_BitingMonster()
        {
            Monster crocodile = MonsterFactory.CreateMonster(MonsterFactory.MonsterType.Crocodile);
            Assert.IsTrue(crocodile is BitingMonster);
        }

        [TestMethod]
        public void Test_BitingKickingMonster()
        {
            Monster horse = MonsterFactory.CreateMonster(MonsterFactory.MonsterType.Horse);

            Assert.IsTrue(horse is BitingMonster);

            // This test will fail, because we cannot inherit from multiple base classes.
            Assert.IsTrue(horse is KickingMonster);
        }
    }
}
