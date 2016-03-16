using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payrol
{
    public abstract class Employee : IEmployee
    {
        public string name { get;  set; }
        public string ssnNumb { get;  set; }

        public Employee(string name,string ssnNumb)  // constructor
        {
            this.name = name;
            this.ssnNumb = ssnNumb;
        }

        public abstract void basicInfo(string n,string m);
        public abstract double calculateSal();

    }

}
