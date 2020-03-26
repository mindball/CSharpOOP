using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace ParkingSystem.Tests
{

    public class SoftParkTest
    {
        private SoftPark softPark;
        private Car car;
        [SetUp]
        public void Setup()
        {
            this.softPark = new SoftPark();
            this.car = new Car("BMW", "ABC123");
        }

        [Test]
        public void ConstructorShouldCreateTwelveEmptyParinkgSpots()
        {
            Assert.That(this.softPark.Parking.Count, Is.EqualTo(12));
        }

        [Test]
        public void ConstructorShouldCreateCorrectSports()
        {
            var myparking = new Dictionary<string, Car>
            {
                {"A1", null},
                {"A2", null},
                {"A3", null},
                {"A4", null},
                {"B1", null},
                {"B2", null},
                {"B3", null},
                {"B4", null},
                {"C1", null},
                {"C2", null},
                {"C3", null},
                {"C4", null},


            };
            foreach (var kvp in this.softPark.Parking)
            {
                Assert.That(
                    myparking.ContainsKey(kvp.Key), Is.EqualTo(true));

                Assert.That(
                    myparking[kvp.Key], Is.EqualTo(null));
            }
        }

        [Test]
        public void ParkingOnInvalidSpotShouldThrowException()
        {
            Assert.Throws<ArgumentException>(
                () => this.softPark.ParkCar("D1", this.car));
        }

        [Test]
        public void ParkingSpotIsBisyShouldThrowException()
        {
            this.softPark.ParkCar("A1", new Car("BMW", "ABC123"));

            Assert.Throws<ArgumentException>(
                () => this.softPark.ParkCar("A1", this.car));
        }

        [Test]
        public void TryParkingSameCardOnAnotherSpotShouldThrowException()
        {

            this.softPark.ParkCar("A1", this.car);

            Assert.Throws<InvalidOperationException>(
                () => this.softPark.ParkCar("B1", this.car));
        }

        [Test]
        public void SuccessfulParkedCarShouldReturnMessage()
        {
            string actualMessage = this.softPark.ParkCar("C1", this.car);
            string expectedMessage = $"Car:{this.car.RegistrationNumber} parked successfully!";

            Assert.That(actualMessage, Is.EqualTo(expectedMessage));
        }

        [Test]
        public void TryRemoveCarFromNoneExistingSpotShouldThrowException()
        {
            Assert.Throws<ArgumentException>(
                () => this.softPark.RemoveCar("D1", this.car));
        }


        [Test]
        public void TryRemoveCarFromWrongExistingSpotShouldThrowException()
        {
            this.softPark.ParkCar("C2", this.car);

            Assert.Throws<ArgumentException>(
                () => this.softPark.RemoveCar("C2", new Car(" ", " ")));
        }

        [Test]
        public void SuccessfulRemoveCarShouldReturnMessage()
        {
            this.softPark.ParkCar("C2", this.car);

            string actualMessage = this.softPark.RemoveCar("C2", this.car);
            string expectedMessage = $"Remove car:{this.car.RegistrationNumber} successfully!";

            Assert.That(actualMessage, Is.EqualTo(expectedMessage));
            Assert.That(this.softPark.Parking["C2"], Is.EqualTo(null));
        }
    }
}