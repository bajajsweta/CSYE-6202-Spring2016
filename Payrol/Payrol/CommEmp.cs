using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payrol
{
    public class CommEmp : Employee
    {
        private double commRate = 0.06;
        private double sales;
        private double totalEaraned;

        public CommEmp(String name,String ssnNumb) : base(name,ssnNumb) { }

          public double salesAmount()
          {
              sales = Double.Parse(Console.ReadLine());
              return sales;
          }
          

        public override double calculateSal()
        {
            totalEaraned = sales*commRate;
            return totalEaraned;
        }

        public override void basicInfo(string name, string ssnNumb)
        {
            Console.Write("Commission Employee : ", name);
            Console.ReadLine();
            Console.Write("Social Security Number : ", ssnNumb);
            Console.ReadLine();
            Console.Write("Gross Sales : $ ");
            sales = Double.Parse(Console.ReadLine());
            Console.Write("Commission Rate : $ " + commRate);
            Console.ReadLine();
        }
    }
}
