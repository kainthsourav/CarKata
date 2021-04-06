using NUnit.Framework;
using CarKataAssignment.Interface;
using Moq;

namespace CarKataAssignment.Test
{
    [TestFixture]
    public class FuelTest
    {
        private Mock<IFuelTank> _mockFuel;
        private FuelTankOperations _TankOperations;

        [SetUp]
        public void Setup()
        {
            _mockFuel = new Mock<IFuelTank>();
            _TankOperations = new FuelTankOperations(_mockFuel.Object);
        }
        [TearDown]
        public void TearDown()
        {
            _mockFuel = null;
        }

        [Test]
        [TestCase(30, true)]
        public void ShouldRefuelCar(int fuel,bool expected)
        {
            _mockFuel.Setup(x => x.Refueled(fuel)).Returns(expected);

            var result = _TankOperations.getRefueled(fuel);

            Assert.IsTrue(result);
        }
    }
}
