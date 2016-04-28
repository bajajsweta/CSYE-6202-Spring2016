using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class RemoveEmployeePage : Form
    {
        public RemoveEmployeePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAL.DataAccess da = new DAL.DataAccess();

            var paramValues = new List<string>();
            
            var paramTypes = new List<string>();

       //     var RemoveEmployeeList = 
            
        }
    }
}
