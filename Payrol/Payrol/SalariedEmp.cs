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
            Console.Write("Social Security Number : ", ssnNumb);
            Console.ReadLine();
           // Console.Write("Weekly Salary : $ " + salary);
           // Console.ReadLine();
        }

     
    }
}
