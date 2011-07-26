using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mileage.Controllers;
using Mileage.Models;
using Moq;

namespace Mileage.Tests.Controllers
{
    [TestClass]
    public class TripControllerTest
    {
        private TripController Subject { get; set; }

        [TestInitialize]
        public void TestInitialize()
        {
            Subject = new TripController();
        }

        [TestMethod]
        public void DefaultConstruction()
        {
            // Arrange
            MileageDB mileageDB = Subject.MileageDB;

            // Assert
            Assert.IsInstanceOfType(Subject, typeof(Controller));
            Assert.IsNotNull(mileageDB);
        }

        [TestMethod]
        public void TripIndex()
        {
            // Act
            ViewResult result = Subject.Index();

            // Assert
            Assert.IsInstanceOfType(result.Model, typeof(DbSet<Trip>));
        }

        [TestMethod]
        public void CreateRequestShouldReturnView()
        {
            // Act
            ViewResult result = Subject.Create();

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CreateShouldAddTripToDatabase()
        {
            // Arrange
            var newTrip = new Trip();
            var mockTrips = MockTrips();

            // Act
            Subject.Create(newTrip);

            // Assert
            mockTrips.Verify(t => t.Add(newTrip));
        }

        [TestMethod]
        public void ShouldSaveChanges()
        {
            // Arrange
            var mockDb = new Mock<MileageDB>();
            Subject.MileageDB = mockDb.Object;

            // Act
            Subject.Create(new Trip());

            // Assert
            mockDb.Verify(db => db.SaveChanges());
        }

        [TestMethod]
        public void CreateShouldRedirectToIndex()
        {
            // Arrange
            MockTrips();

            // Act
            RedirectToRouteResult result = Subject.Create(new Trip());

            // Assert
            Assert.AreEqual("Index", result.RouteValues["action"]);
        }

        [TestMethod]
        public void CreateShouldHavePostAttribute()
        {
            // Arrange
            var createMethod = Subject.GetType().GetMethod("Create", new Type[] { typeof(Trip) });

            // Act
            var attributes = createMethod.GetCustomAttributes(false);

            // Assert
            Assert.IsInstanceOfType(attributes.First(), typeof(HttpPostAttribute));
        }

        // TODO: what if savechanges fails in Create

        private Mock<IDbSet<Trip>> MockTrips()
        {
            var mockTrips = new Mock<IDbSet<Trip>>();
            Subject.MileageDB.Trips = mockTrips.Object;
            return mockTrips;
        }

    }
}
