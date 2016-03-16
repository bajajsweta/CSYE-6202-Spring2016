using NUnit.Framework;

namespace Payroll.Tests
{
  

    [TestFixture]
    public class WhenGeneratingPayrollReport
    {

        string name = null;
        string ssnNumb = null;
        Payrol.HourlyEmp e2;

        [TestFixtureSetUp]
        public void FixtureSetup()
        {
            Payrol.HourlyEmp e2 = new Payrol.HourlyEmp(name, ssnNumb);
        }

        #region userEnterednotnull Tests

        [Test]
        public void When_UserEnteredHours_Notnull()
        {
            // prepare
            var expected = false;

            // action
           var actual = e2.EnterHours(5.5);

            // assert
           Assert.That(expected, Is.EqualTo(actual));
        }

       #endregion


    }
}
