using System;
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
            DateTime startTime = subject.StartTime;
            DateTime endTime = subject.EndTime;
            string startLocation = subject.StartLocation;
            string endLocation = subject.EndLocation;

            // Assert
            Assert.AreEqual(0, id);
            Assert.AreEqual(0, odometerStart);
            Assert.AreEqual(0, odometerEnd);
            //var today = DateTime.Now.ToShortDateString();
            //Assert.AreEqual(today, startTime.ToShortDateString());
            //Assert.AreEqual(today, endTime.ToShortDateString());
        }
    }
}
