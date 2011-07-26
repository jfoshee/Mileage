using System.Data.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mileage.Models;

namespace Mileage.Tests.Models
{
    [TestClass]
    public class MileageDBTest
    {
        [TestMethod]
        public void DefaultConstruction()
        {
            // Arrange
            var subject = new MileageDB();
            IDbSet<Trip> trips = subject.Trips;

            // Assert
            Assert.IsInstanceOfType(subject, typeof(DbContext));
            Assert.IsNotNull(trips);
        }
    }
}
