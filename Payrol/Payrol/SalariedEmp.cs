using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payrol
{
    public class SalariedEmp : Employee
    {
        private double salary = 800;
        private double totalEarned;
        private string secNumber;
        const int MaxLength = 10;

        public SalariedEmp(String name,String ssnNumb) : base(name,ssnNumb)
        {  }

        public override double calculateSal()
        {

            Console.Write("Weekly Salary : $ " + salary);
            Console.ReadLine();
            totalEarned = salary;
            return totalEarned;

        }

        public override void basicInfo(string name, string ssnNumb)
        {
            
            Console.Write("Salaried Employee : ", name);
            Console.ReadLine();
            Console.Write("Social Security Number : ");
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

            // Console.Write("Weekly Salary : $ " + salary);
            // Console.ReadLine();G:\INFO 6202 C#\CSYE_6200_Payroll\Payrol\Payrol\SalariedEmp.cs
        }


    }
}
