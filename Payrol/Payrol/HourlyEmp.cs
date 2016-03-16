using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payrol
{
    public class HourlyEmp : Employee
    {
        private double hourlyWage = 16.75;
        private double hours;
        private string hoursCheck;
        private double totalEaraned;
        private string secNumber;
        const int MaxLength = 10;

        public HourlyEmp(string name, string ssnNumb) : base(name, ssnNumb) { }


        public void hourlyWages()
        {
            Console.Write("Hourly Wage : $ " + hourlyWage);
            Console.ReadLine();
            Console.Write("Enter Hours Worked : ");
            /* hoursCheck = (Console.ReadLine());
             if (hoursCheck.Equals(" "))
             {
                 Console.Write("Please Enter the Number of hours :");
                 hours = double.Parse(Console.ReadLine());
             }
             else { hours = double.Parse(hoursCheck); }
             */
            hours = double.Parse(Console.ReadLine());
            EnterHours(hours);
        }
        

        public bool EnterHours(double hours)
        {
            var result = false;

            // your implementation here
            if (hours > 0.0 && hours <= 40.0)
            {
                Convert.ToDouble(hours);
                result = true;
            }
            return result;
        }

        public override double calculateSal()
        {
            totalEaraned = hours * hourlyWage;
            return totalEaraned;
        }

        public override void basicInfo(string name, string ssnNumb)
        {
            Console.Write("Hourly Employee");
            name = Console.ReadLine();
            Console.Write("Enter Name :");
            name = Console.ReadLine();
            Console.Write("Enter Social Security Number : ");
            ssnNumb = Console.ReadLine();
            secNumber = ssnNumb;

            if (secNumber.Length > MaxLength)
            {
                Console.Write("Correct Social Security Number : ");
                Console.Write(ssnNumb.Substring(0, 10));
                Console.ReadLine();
            }
            else if (secNumber.Length < MaxLength)
            {
                Console.Write("Enter Correct Social Security Number : ");
                ssnNumb = Console.ReadLine();
                secNumber = ssnNumb;
            }

        }


    }
}

