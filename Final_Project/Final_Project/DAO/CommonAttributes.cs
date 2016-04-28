
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DAO
{
    public class CommonAttributes
    {
        public string EmployeeName { get; set; }

        public string AdminName { get; set; }


        private static CommonAttributes Instance = null;

        private CommonAttributes()
        {
            //  DO nothing..
        }

        public static CommonAttributes GetInstance()
        {
            if(Instance == null)
            {

                Instance = new CommonAttributes();
            }

            return Instance;

        }

    }
}
