using NUnit.Framework;
using System;

namespace Tests
{
    using Database;
    public class DatabaseTests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConstructorShouldBeInitilizedWith16thElements()
        {
            int[] array = new int[16];
            Database database = new Database(array);

            int expectedCount = 16;
            int actualCount = database.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestCase(new int[] { 1, 2, 3, 2, 3, 2, 3, 2, 3, 2, 3, 2, 3, 2, 3, 2, 3 })]
        public void ConstructorShouldThrowInvalidOperationExceptionIsNotExactrly(int[] array)
        {
            Assert.Throws<InvalidOperationException>(() =>
            new Database(array));
        }


        [Test]
        public void AddMethodShouldIncreaseTheCount()
        {
            Database database = new Database();
            database.Add(1);

            int expectedCount = 1;
            int actualCount = database.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void AddMethodShouldAddOnTheNextEmptyIndex()
        {
            int[] array = { 1, 2, 3, 4, 5 };
            Database database = new Database(array);
            database.Add(6);

            int expectedResult = 6;
            int actualResult = database.Fetch()[5];

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void AddMethodShouldThrowInvalidOperationExceptionWhenElementsAreExceeded()
        {
            int[] array = new int[16];
            Database database = new Database(array);

            Assert.Throws<InvalidOperationException>(() =>
                database.Add(1));
        }

        [Test]
        public void ShouldRemoveCorrectlyAndDecreaseCount()
        {
            int[] array = { 1, 2, 3 };
            Database database = new Database(array);
            database.Remove();

            int expectedCount = 2;
            int actualCount = database.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void ShouldRemoveCorrectlyLastElement()
        {
            int[] array = { 1, 2, 3 };
            Database database = new Database(array);
            database.Remove();

            int expectedCount = 2;
            int actualCount = database.Fetch()[1];

            Assert.AreEqual(expectedCount, actualCount);
        }

        // throw new InvalidOperationException("The collection is empty!");
        [Test]
        public void RemoveMethodShouldThrowInvalidOperationExceptionWhenCountIsZero()
        {
            Assert.Throws<InvalidOperationException>(() =>
               new Database().Remove());
        }

        [Test]
        public void FetchMethodShouldReturnAllElementsAsArray()
        {
            int[] array = { 1, 5, 2, 4, 5 };
            Database database = new Database(array);

            int[] expectedValues = { 1, 5, 2, 4, 5 };
            int[] actualValues = database.Fetch();

            CollectionAssert.AreEqual(expectedValues, actualValues);
        }
    }
}