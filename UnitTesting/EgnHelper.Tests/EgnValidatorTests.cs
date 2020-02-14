using NUnit.Framework;
using System;

namespace EgnHelper.Tests
{

    /*
     * AAA Testin Patter
     * Arrange
     * Act
     * Assert
     * 
     * Целта на тестването е тестването да гърми!!
     *  - търсими проблеми, пролуки, слабости, уязвимости (гледаме да счупим кода)
     *  - Не правим UnitTest за да докажем, че ни е добър кода
     * */

    [TestFixture]
    public class EgnValidatorTests
    {

        
        //Скелет
        //Ако искаме да преизползваме някаква логика
        [SetUp]
        public void StartBeforTest()
        {
            //Например SetUp имаме сложен конструктор с много параметри да не го пиша всеки път
            Console.WriteLine("Before");
        }

        [TearDown]
        public void AfterTest()
        {
            //Например TearDown може да се ползва когато искаме да зачистим някакви ресурси.
            Console.WriteLine("After");
        }

        //expected value
        [Test]
        public void IsValidMethodShouldReturnTrueForValidEgn()
        {
            Console.WriteLine("In test");
            //steps;
            //1. Arrange
            var validator = new EgnValidator();

            //2. Act
            var result = validator.IsValid("6101057509");

            //3. Assert
            Assert.IsTrue(result);
        }        

        //Check Expected null exception
        [Test]
        public void IsValidMethodHandlingNullException()
        {
            Console.WriteLine("In test");
            var validator = new EgnValidator();

            Assert.Throws<ArgumentNullException>(() => validator.IsValid(null));           
        }

        [TestCase("752316263")]
        [TestCase("6101057509")]
        [TestCase("4552010005")]
        public void IsValidMethodShouldReturnTrueForValidEgnWithParameters(string egn)
        {
            //Премахва повторяемостта ако например тестваме egn с различни стойности
            var validator = new EgnValidator();
           
            var result = validator.IsValid(egn);
           
            Assert.IsTrue(result);
        }

        [TestCase("11111111", "Only once")]
        [TestCase("asdasdasdasdasd", "Not Digit")]
        [TestCase("", "Empty String")]
        [TestCase("752316262", "Invalid checksum")]
        public void IsValidMethodShouldReturnFalseForValidEgnWithParametersAndCustomeMessage(string egn, string message)
        {
            //Премахва повторяемостта ако например тестваме egn с различни стойности
            var validator = new EgnValidator();

            var result = validator.IsValid(egn);

            Assert.IsTrue(result, message);
        }
    }
}
