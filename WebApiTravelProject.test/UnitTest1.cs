using Microsoft.AspNetCore.Http.HttpResults;
using WebApiWithController.Controllers;
using WebApiWithController.Models;
namespace WebApiTravelProject.test
{
    public class Tests
    {
        private BookingController controller;
        [SetUp]
        public void Setup()
        {
            controller = new BookingController();
        }

        [Test]
        public void TestMethodForGetTeacher()
        {
            IEnumerable<BookingModel> result = controller.Getbookinglist();
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count(), Is.EqualTo(0));
        }
        [Test]
        public void TestMethodForPostTeacher()
        {
            var newItem = new BookingModel
            {
                Id = 1,
                CarNo = "test",
                DateOfBooking = "test",
                FromLocation = "test",
                ToLocation = "test",
                CustomerName = "test",
                MobileNumber = "test",
            };
            var actionResult = controller.Postbookinglist(newItem);
            Assert.That(actionResult, Is.Not.Null);
        }
        [Test]
        public void TestMethodForPostTeacherNull()
        {
            var newItem = new BookingModel
            {
                Id = 1,
                CarNo = null,
                DateOfBooking = null,
                FromLocation = null,
                ToLocation = null,
                CustomerName = null,
                MobileNumber = null
            };
            var actionResult = controller.Postbookinglist(newItem);
            Assert.IsNotInstanceOf<BadRequest>(actionResult);
        }
    }
}