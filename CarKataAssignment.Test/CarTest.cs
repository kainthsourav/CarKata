using CarKataAssignment.Interface;
using Moq;
using NUnit.Framework;

namespace CarKataAssignment.Test
{
    [TestFixture]
    public class CarTest
    {
        private Mock<ICar> _mockCar;
        private CarOperations _car;

        [SetUp]
        public void Setup()
        {
            _mockCar = new Mock<ICar>();
            _car = new CarOperations(_mockCar.Object);
        }
        [TearDown]
        public void TearDown()
        {
            _mockCar = null;
        }

        [Test]
        public void shouldStartCar()
        {
            _mockCar.Setup(x => x.Start()).Returns(true);

            var result = _car.StartCar();

            Assert.IsTrue(result);
        }

        [Test]
        public void shouldStopCar()
        {
            _mockCar.Setup(x => x.Stop()).Returns(true);

            var result = _car.StopCar();

            Assert.IsTrue(result);
        }

        [Test]
        [TestCase(10,true)]
        public void shouldAccelerateCar(int speed, bool expected)
        {
            _mockCar.Setup(x => x.Accelerate(speed)).Returns(expected);

            var result = _car.AccelerateCar(speed);

            Assert.AreEqual(result, expected);
        }

        [Test]
        [TestCase(20,true)]
        public void shouldApplyBrake(int speed,bool expected)
        {
            _mockCar.Setup(x => x.ApplyBrake(speed)).Returns(expected);

            var result = _car.ApplyBrake(speed);

            Assert.AreEqual(result, expected);
        }
        
    }
}
