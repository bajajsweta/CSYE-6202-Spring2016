using Final_Project.DAO;
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

    public partial class LoginPage : Form

    {

        private static readonly log4net.ILog Log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public LoginPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DAL.DataAccess da = new DAL.DataAccess();

            var paramValues = new List<string>();
            paramValues.Add(userName_txt.Text);
            paramValues.Add(password_txt.Text);
            
            var paramTypes = new List<string>();
            paramTypes.Add("string");
            paramTypes.Add("string");

            var authentiactionlist = da.runProcedure("UserAuthentication", paramValues, paramTypes);
            var list = authentiactionlist.ConvertAll(l => l[0].ToString());

            if (list.Contains("Admin"))
            {
                CommonAttributes.GetInstance().AdminName = userName_txt.Text;
                AdminPage ap = new AdminPage();
                this.Close();
                ap.Show();
                Log.Info("Admin Logged in : " + CommonAttributes.GetInstance().AdminName);
            }
            else if (list.Contains("Staff") || list.Contains("Pilot"))
            {

                CommonAttributes.GetInstance().EmployeeName = userName_txt.Text;
                EmployeeCustomerPage ecp = new EmployeeCustomerPage();
                this.Close();
                ecp.Show();
                Log.Info("Admin Logged in : " + CommonAttributes.GetInstance().EmployeeName);
            }
            else
            {
                MessageBox.Show("Please enter correct credentials");
            }
        }
    }
}
