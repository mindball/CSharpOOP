using CarManager;
using NUnit.Framework;
using System;

namespace Tests
{
    public class CarTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            string make = "VW";
            string model = "golf";
            double fuelConsumption = 2;
            double fuelCapacity = 100;

            Car car = new Car(make, model, fuelConsumption, fuelCapacity);

            Assert.AreEqual(make, car.Make);
            Assert.AreEqual(model, car.Model);
            Assert.AreEqual(fuelConsumption, car.FuelConsumption);
            Assert.AreEqual(fuelCapacity, car.FuelCapacity);
        }

        [Test]
        public void ModelShouldThrowArgumentExceptionWhenNameIsNull()
        {
            // throw new ArgumentException("Model cannot be null or empty!");
            string make = "VW";
            string model = null;
            double fuelConsumption = 2;
            double fuelCapacity = 100;

            Assert
                .Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity));            
        }

        [Test]
        public void MakeShouldThrowArgumentExceptionWhenValueIsNull()
        {
            // throw new ArgumentException("Make cannot be null or empty!");
            string make = null;
            string model = "golf";
            double fuelConsumption = 2;
            double fuelCapacity = 100;

            Assert
                .Throws<ArgumentException>(
                () => new Car(make, model, fuelConsumption, fuelCapacity));
        }

        [Test]
        public void FuelConsumptionShouldThrowArgumentExceptionWhenValueIsNegative()
        {
            // throw new ArgumentException("Fuel consumption cannot be zero or negative!");
            string make = "VW";
            string model = "golf";
            double fuelConsumption = -1;
            double fuelCapacity = 100;

            Assert
                .Throws<ArgumentException>(
                () => new Car(make, model, fuelConsumption, fuelCapacity));
        }

        [Test]
        public void FuelConsumptionShouldThrowArgumentExceptionWhenValueIsZero()
        {
            // throw new ArgumentException("Fuel consumption cannot be zero or negative!");
            string make = "VW";
            string model = "golf";
            double fuelConsumption = 0;
            double fuelCapacity = 100;

            Assert
                .Throws<ArgumentException>(
                () => new Car(make, model, fuelConsumption, fuelCapacity));
        }

        [Test]
        public void FuelCapacityShouldThrowArgumentExceptionWhenValueIsNegative()
        {
            // throw new ArgumentException("Fuel Capacity cannot be zero or negative!");
            string make = "VW";
            string model = "golf";
            double fuelConsumption = 2;
            double fuelCapacity = -10;

            Assert
                .Throws<ArgumentException>(
                () => new Car(make, model, fuelConsumption, fuelCapacity));
        }

        [Test]
        public void FuelCapacityShouldThrowArgumentExceptionWhenValueIsZero()
        {
            // throw new ArgumentException("Fuel Capacity cannot be zero or negative!");
            string make = "VW";
            string model = "golf";
            double fuelConsumption = 2;
            double fuelCapacity = 0;

            Assert
                .Throws<ArgumentException>(
                () => new Car(make, model, fuelConsumption, fuelCapacity));
        }

        [TestCase(null, "golf", 2, 10)]
        [TestCase("vw", null, 2, 10)]
        [TestCase("vw", "golf", 0, 10)]
        [TestCase("vw", "golf", -10, 10)]
        [TestCase("vw", "golf", 5, 0)]
        [TestCase("vw", "golf", 5, -5)]

        public void AllProperiesShouldThrowsArgumentExceptionForInvalidValues(
            string make, string model, double fuelConsumption, double fuelCapacity)
        {
            Assert
                .Throws<ArgumentException>(
                () => new Car(make, model, fuelConsumption, fuelCapacity));
        }

        [Test]
        public void ShouldRefuelNormally()
        {
            string make = "VW";
            string model = "golf";
            double fuelConsumption = 2;
            double fuelCapacity = 100;

            Car car = new Car(make, model, fuelConsumption, fuelCapacity);
            car.Refuel(10);

            double expectedFuelAmount = 10;
            double actualFuelAmount = car.FuelAmount;

            Assert.AreEqual(expectedFuelAmount, actualFuelAmount);
        }

        [Test]
        public void ShouldRefuelUntilTheTotalFuelCapacityIsOverflow()
        {
            string make = "VW";
            string model = "golf";
            double fuelConsumption = 2;
            double fuelCapacity = 100;

            Car car = new Car(make, model, fuelConsumption, fuelCapacity);
            car.Refuel(150);

            double expectedFuelAmount = 100;
            double actualFuelAmount = car.FuelAmount;

            Assert.AreEqual(expectedFuelAmount, actualFuelAmount);
        }

        [TestCase(-10)]
        [TestCase(0)]

        public void RefuelShouldThrowArgumentExceptionWhenAmountIsBellowZero(
            double inputAmount)
        {
            string make = "VW";
            string model = "golf";
            double fuelConsumption = 2;
            double fuelCapacity = 100;

            Car car = new Car(make, model, fuelConsumption, fuelCapacity);

            Assert.Throws<ArgumentException>(() =>
                car.Refuel(inputAmount));
        }

        [Test]
        public void ShouldDriveNormaly()
        {
            string make = "VW";
            string model = "golf";
            double fuelConsumption = 2;
            double fuelCapacity = 100;

            Car car = new Car(make, model, fuelConsumption, fuelCapacity);
            car.Refuel(20);
            car.Drive(20);

            double expectedFuelAmount = 19.6;
            double actualFuelAmount = car.FuelAmount;

            Assert.AreEqual(expectedFuelAmount, actualFuelAmount);
        }

        [Test]
        public void DriveShouldThrowInvalidOperationExceptionWhenFuelAmountIsNotEnough()
        {
            string make = "VW";
            string model = "golf";
            double fuelConsumption = 2;
            double fuelCapacity = 100;

            Car car = new Car(make, model, fuelConsumption, fuelCapacity);           
            Assert.Throws<InvalidOperationException>( () => car.Drive(20));           
        }
    }
}