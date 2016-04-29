
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DAO
{
    public class ConstantAttributes
    {
        public string EmployeeName { get; set; }

        public string AdminName { get; set; }

        public string CustomerName { get; set; }


        private static ConstantAttributes Instance = null;

        private ConstantAttributes()
        {
            //  DO nothing..
        }

        public static ConstantAttributes GetInstance()
        {
            if(Instance == null)
            {

                Instance = new ConstantAttributes();
            }

            return Instance;

        }

    }
}
