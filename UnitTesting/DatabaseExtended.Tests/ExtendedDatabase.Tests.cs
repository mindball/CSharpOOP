using NUnit.Framework;
using DatabaseExtended;
using System;

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        [Test]
        public void ConstructorShouldBeInitilizedWith16thElementOfPerson()
        {
            Person[] persons =
            {
                new Person(1, "oilaripi"),
                new Person(2, "asdz"),
                new Person(3, "wez"),
                new Person(4, "zzw"),
                new Person(5, "aaa"),
                new Person(6, "qwe"),
                new Person(7, "dvco"),
                new Person(8, "sedp"),
                new Person(9, "hg"),
                new Person(10, "mnbhg"),
                new Person(11, "rto"),
                new Person(12, "ghti"),
                new Person(13, "ghjy"),
                new Person(14, "rtyi"),
                new Person(15, "eri"),
                new Person(16, "weho")
            };
            ExtendedDatabase database = new ExtendedDatabase(persons);

            int expectedCountOfPerson = 16;
            int actualCountOfPerson = database.Count;

            Assert.AreEqual(expectedCountOfPerson, actualCountOfPerson);
        }

        [Test]
        public void ConstructorShouldBeThrowArgumentExceptionWhenPersonCountAreMoreThan16()
        {
            Person[] persons =
            {
                new Person(1, "oilaripi"),
                new Person(2, "asdz"),
                new Person(3, "wez"),
                new Person(4, "zzw"),
                new Person(5, "aaa"),
                new Person(6, "qwe"),
                new Person(7, "dvco"),
                new Person(8, "sedp"),
                new Person(9, "hg"),
                new Person(10, "mnbhg"),
                new Person(11, "rto"),
                new Person(12, "ghti"),
                new Person(13, "ghjy"),
                new Person(14, "rtyi"),
                new Person(15, "eri"),
                new Person(16, "eriasw"),
                new Person(17, "eridsw"),

            };

            Assert.Throws<ArgumentException>(
                () => new ExtendedDatabase(persons));
        }

        [Test]
        public void AddMethodShouldIncreaseTheCount()
        {
            Person[] persons = new Person[]
                {
                    new Person(1, "oilaripi")
                };
            ExtendedDatabase database = new ExtendedDatabase(persons);
            database.Add(new Person(2, "asd"));

            int expectedCount = 2;
            int actualCount = database.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void AddMethodShouldThrowInvalidOperationExceptionWhenElementsAreExceeded()
        {
            Person[] persons =
           {
                new Person(1, "oilaripi"),
                new Person(2, "asdz"),
                new Person(3, "wez"),
                new Person(4, "zzw"),
                new Person(5, "aaa"),
                new Person(6, "qwe"),
                new Person(7, "dvco"),
                new Person(8, "sedp"),
                new Person(9, "hg"),
                new Person(10, "mnbhg"),
                new Person(11, "rto"),
                new Person(12, "ghti"),
                new Person(13, "ghjy"),
                new Person(14, "rtyi"),
                new Person(15, "eri"),
                new Person(16, "weho")
            };

            ExtendedDatabase database = new ExtendedDatabase(persons);

            Assert.Throws<InvalidOperationException>(() =>
                database.Add(new Person(17, "EmptyUsername")));
        }
        
        [Test]
        public void AddMethodShouldThrowInvalidOperationExceptionWhenUserNameAreDuplicate()
        {
            Person[] persons =
          {
                new Person(1, "dizela")
          };

            ExtendedDatabase database = new ExtendedDatabase(persons);
            Assert.Throws<InvalidOperationException>(() =>
                database.Add(new Person(2, "dizela")));
        }

        [Test]
        public void AddMethodShouldThrowInvalidOperationExceptionWhenUserIDAreDuplicate()
        {
            Person[] persons =
          {
                new Person(1, "dizela")
          };

            ExtendedDatabase database = new ExtendedDatabase(persons);
            Assert.Throws<InvalidOperationException>(() =>
                database.Add(new Person(1, "petrola")));
        }

        [Test]
        public void ShouldRemoveCorrectlyAndDecreaseCount()
        {
            Person[] persons =
            {
                new Person(1, "dizela"),
                new Person(2, "petrola")
            };

            ExtendedDatabase database = new ExtendedDatabase(persons);
            database.Remove();

            int expectedCount = 1;
            int actualCount = database.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }
                
        [Test]
        public void RemoveMethodShouldThrowInvalidOperationExceptionWhenCountIsZero()
        {
            Person[] persons =
            {
                new Person(1, "dizela")
            };

            ExtendedDatabase database = new ExtendedDatabase(persons);
            database.Remove();

            Assert.Throws<InvalidOperationException>(() =>
               database.Remove());
        }

        [Test]
        public void FindPersonByUsername()
        {
            Person person = new Person(1, "dizela");
            Person[] persons = new Person[]
                { person };

            ExtendedDatabase database = new ExtendedDatabase(persons);

            var expectedPersonUserName = person;
            var actualPersonUserName = database.FindByUsername("dizela");

            Assert.AreEqual(expectedPersonUserName, actualPersonUserName);
        }

        [Test]
        public void FindByUsernameShouldThrowInvalidOperationExceptionWhenNoUserIsPresentByThisUserName()
        {
            Person[] persons =
            {
                new Person(1, "oilaripi"),
                new Person(2, "asdz"),
                new Person(3, "wez"),
                new Person(4, "zzw"),
            };

            ExtendedDatabase database = new ExtendedDatabase(persons);
            Assert.Throws<InvalidOperationException>(
                () => database.FindByUsername("test"));
        }

        [Test]
        public void FindByUsernameShouldThrowArgumentNullExceptionWhenUserNameParameterIsNull()
        {
            Person[] persons =
            {
                new Person(1, "oilaripi"),
                new Person(2, "asdz"),
                new Person(3, "wez"),
                new Person(4, "zzw"),
            };

            ExtendedDatabase database = new ExtendedDatabase(persons);
            Assert.Throws<ArgumentNullException>(
                () => database.FindByUsername(""));
        }

        [Test]
        public void FindPersonByUserID()
        {
            Person person = new Person(1, "dizela");
            Person[] persons = new Person[]
                { person };

            ExtendedDatabase database = new ExtendedDatabase(persons);

            var expectedPersonByID = person;
            var actualPersonUserByID = database.FindById(1);

            Assert.AreEqual(expectedPersonByID, actualPersonUserByID);
        }

        [Test]
        public void FindPersonByUserIDShouldThrowInvalidOperationExceptionWhenNoUserIsPresentByThisId()
        {
            Person[] persons =
           {
                new Person(1, "oilaripi"),
                new Person(2, "asdz"),
                new Person(3, "wez"),
                new Person(4, "zzw"),
            };

            ExtendedDatabase database = new ExtendedDatabase(persons);
            Assert.Throws<InvalidOperationException>(
                () => database.FindById(5));
        }

        [Test]
        public void FindPersonByUserIDShouldThrowArgumentOutOfRangeExceptionWhenNegativeIDAreFound()
        {
            Person[] persons =
           {
                new Person(1, "oilaripi"),
                new Person(2, "asdz"),
                new Person(3, "wez"),
                new Person(4, "zzw"),
            };

            ExtendedDatabase database = new ExtendedDatabase(persons);
            Assert.Throws<ArgumentOutOfRangeException>(
                () => database.FindById(-1));
        }
    }
}