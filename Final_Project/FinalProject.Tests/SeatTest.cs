using Final_Project.DAO;
using NUnit.Framework;

namespace FinalProject.Tests
{
    [TestFixture]
    public class SeatTest
    {

        [Test]
        public void When_EconomySeatBooked()
        {
            FlightSchedule flightSchedule = new FlightSchedule();
            flightSchedule.FlightDuration = 2;
            ISeat seat = new EconomySeat();
            var price = seat.CalculatePrice(flightSchedule);

            Assert.AreEqual(price, 600);
        }


    }
}
