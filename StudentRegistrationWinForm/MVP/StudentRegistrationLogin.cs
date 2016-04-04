using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationWinForm
{
    public partial class StudentRegistrationLogin : Form
    {

        private string UserName = "Sweta";
        private string Password = "Sweta";
        private int LoginAttempt = 0;

        public StudentRegistrationLogin()
        {
            InitializeComponent();
        }

        private void button_signin_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == UserName && masked_txt_password.Text == Password)
            {
                MessageBox.Show("Logged In Successfully");
                this.Hide();
                StudentRegistrationMainWindow studentRegister = new StudentRegistrationMainWindow();
                studentRegister.Closed += (s, args) => this.Close();
                studentRegister.Show();
            }
            else if (LoginAttempt >= 2)
            {
                MessageBox.Show("Invalid Credentials");
                Close();
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
                LoginAttempt++;
            }
        }
    }
}
