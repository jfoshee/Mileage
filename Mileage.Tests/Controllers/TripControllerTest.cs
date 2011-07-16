using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mileage.Controllers;
using System.Web.Mvc;
using Mileage.Models;

namespace Mileage.Tests.Controllers
{
    [TestClass]
    public class TripControllerTest
    {
        [TestMethod]
        public void DefaultConstruction()
        {
            // Arrange
            var subject = new TripController();
            MileageDB mileageDB = subject.MileageDB;

            // Assert
            Assert.IsInstanceOfType(subject, typeof(Controller));
            Assert.IsNotNull(mileageDB);
        }

        [TestMethod, Ignore]
        public void TripIndex()
        {
            // Arrange
            var subject = new TripController();

            // Act
            ViewResult result = subject.Index();

            // Assert
            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Model);
            Assert.AreSame(subject.MileageDB.Trips, result.Model);
        }
    }
}
