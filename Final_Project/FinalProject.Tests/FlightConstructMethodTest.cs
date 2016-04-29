using Final_Project.DAO;
using NUnit.Framework;
using System.Collections.Generic;

using System.Linq;

namespace FinalProject.Tests
{
    [TestFixture]
    public class FlightConstructMethodTest
    {

        [Test]
        public void When_FlightConstruct()
        {
            List<object> objList = new object[] {
                1,
                "Basil",
                "Spice Jet",
                25
            }.ToList();

            Flight f = Flight.construct(objList);

            Assert.AreEqual(f.Name, "Basil");
            Assert.AreEqual(f.Id, 1);
            Assert.AreEqual(f.Carrier , "Spice Jet");
            Assert.AreEqual(f.NumberOfSeats, 25);
        }

        [Test]
        public void When_EconomySeatBooked()
        {
            List<object> objList = new object[] {
                1,
                "Basil",
                "Spice Jet",
                -205
            }.ToList();

            Flight f = Flight.construct(objList);

            Assert.Null(f);
        }
    }
}
