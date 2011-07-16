using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mileage.Models;

namespace Mileage.Tests.Models
{
    [TestClass]
    public class TripTest
    {
        [TestMethod]
        public void DefaultConstruction()
        {
            // Arrange
            var subject = new Trip();
            int id = subject.Id;
            int odometerStart = subject.OdometerStart;
            int odometerEnd = subject.OdometerEnd;

            // Assert
            Assert.AreEqual(0, id);
            Assert.AreEqual(0, odometerStart);
            Assert.AreEqual(0, odometerEnd);
        }
    }
}
