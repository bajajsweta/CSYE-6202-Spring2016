using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payrol
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string name = null;
            string ssnNumb = null;
           // double hours = 0.0;
            
            SalariedEmp e1 = new SalariedEmp(name,ssnNumb);
            e1.basicInfo(name, ssnNumb);
            Console.Write("Earned Salary : $ " + e1.calculateSal());
            Console.ReadLine();

          
            HourlyEmp e2 = new HourlyEmp(name, ssnNumb);
            Console.Write(" ");
            Console.ReadLine();
            e2.basicInfo(name, ssnNumb);
            e2.hourlyWages();
           // Console.Write("Enter Hours Worked : ");
           // hours = double.Parse(Console.ReadLine());
           // e2.EnterHours(hours);
            Console.Write("Earned Salary : $ " + e2.calculateSal());
            Console.ReadLine();


            CommEmp e3 = new CommEmp(name, ssnNumb);
            Console.Write(" ");
            Console.ReadLine();
            e3.basicInfo(name, ssnNumb);
            Console.Write("Earned Salary : $ " + e3.calculateSal());
            Console.ReadLine();

            BasicSalCommEmp e4 = new BasicSalCommEmp(name, ssnNumb);
            Console.Write(" ");
            Console.ReadLine();
            e4.basicInfo(name, ssnNumb);
            Console.Write("Earned Salary : $ " + e4.calculateSal());
            Console.ReadLine();
                   
        }
    }
} 
