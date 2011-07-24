using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mileage.Controllers;
using Mileage.Models;

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

        [TestMethod, Ignore]
        public void CreateShouldAddTripToDatabase()
        {
            // Arrange
            var newTrip = new Trip();

            // Act
            RedirectToRouteResult result = Subject.Create(newTrip);

            // Assert
            CollectionAssert.Contains(Subject.MileageDB.Trips.ToList(), newTrip);
        }

        [TestMethod, Ignore]
        public void CreateShouldRedirectToIndex()
        {
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

    }

    //class MockMileageDB : MileageDB
    //{
    //    public MockMileageDB()
    //    {
    //        this.Trips = new DbSet<Trip>();
    //    }
    //}
}
