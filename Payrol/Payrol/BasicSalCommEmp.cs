using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payrol
{
    public class BasicSalCommEmp : Employee
    {
        private double commRate = 0.04;
        private double basicSal = 300.00;
        private double sales;
        private double totalEaraned;

        public BasicSalCommEmp(String name, String ssnNumb) : base(name, ssnNumb) { }
        /*
          public double salesAmount()
          {
              sales = Double.Parse(Console.ReadLine());
              return sales;
          }
       */
        public override double calculateSal()
        {
            totalEaraned = sales * commRate + basicSal;
            return totalEaraned;
        }

        public override void basicInfo(string name, string ssnNumb)
        {
            Console.Write("Basic Salaried Commission Employee : ", name);
            Console.ReadLine();
            Console.Write("Social Security Number : ", ssnNumb);
            Console.ReadLine();
            Console.Write("Gross Sales : $ ");
            sales = Double.Parse(Console.ReadLine());
            Console.Write("Commission Rate : $ " + commRate);
            Console.ReadLine();
            Console.Write("Basic Salary : $ " + basicSal);
            Console.ReadLine();
        }
    }
}
