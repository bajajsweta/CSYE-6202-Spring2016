using NUnit.Framework;

namespace Payroll.Tests
{

    [TestFixture]
    public class WhenGeneratingPayrollReport
    {

        string name = null;
        string ssnNumb = null;

        #region userEnteredHours Tests

        [Test]
        public void When_UserEnteredHours_LessThanZero()
        {
            // prepare
            var expected = false;

            // action
            Payrol.HourlyEmp e2 = new Payrol.HourlyEmp(name, ssnNumb);
            var actual = e2.EnterHours(-1);

            // assert
           Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void When_UserEnteredHours_GreaterThanZero()
        {
            // prepare
            var expected = true;

            // action
            Payrol.HourlyEmp e2 = new Payrol.HourlyEmp(name, ssnNumb);
            var actual = e2.EnterHours(5.0);

            // assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void When_UserEnteredHours_IsGreaterThan40()
        {
            // prepare
            var expected = false;

            // action
            Payrol.HourlyEmp e2 = new Payrol.HourlyEmp(name, ssnNumb);
            var actual = e2.EnterHours(41);

            // assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        #endregion

        #region userEnteredSales Tests

        [Test]
        public void When_UserEnteredSales_LessThanZero()
        {
            // prepare
            var expected = false;

            // action
            Payrol.CommEmp e3 = new Payrol.CommEmp(name, ssnNumb);
            var actual = e3.EnterSales(-1);

            // assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        [Test]
        public void When_UserEnteredSales_GreaterThanZero()
        {
            // prepare
            var expected = true;

            // action
            Payrol.CommEmp e3 = new Payrol.CommEmp(name, ssnNumb);
            var actual = e3.EnterSales(1000);

            // assert
            Assert.That(expected, Is.EqualTo(actual));
        }

        #endregion
    }
}
