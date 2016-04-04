using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP
{
    public partial class NewStudentRegistration : Form
    {
        public event EventHandler newStudentAdded;
        public BindingList<StudentInfo> students;
        private List<string> deptType;
        string IDPattern = @"^\d{3}\-?\d{2}\-?\d{4}$";

        public NewStudentRegistration()
        {
            InitializeComponent();
            comboBox_dept.DataSource = fillDeptType();
            button_addStudent.Enabled = false;
            button_resetStudent.Enabled = false;
        }

        public List<string> fillDeptType()
        {
            deptType = new List<string>();
            deptType.Add("Informations Systems");
            deptType.Add("International Affairs Systems");
            deptType.Add("Nursing Systems");
            deptType.Add("Pharmacy Systems");
            deptType.Add("Professional Studies Systems");
            return deptType;
        }

        private void NewStudentRegistration_Load(object sender, EventArgs e)
        {

        }
        //
        private void button_addStudent_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(IDPattern);
            bool Matching = regex.IsMatch(maskedtxt_registerstudentID.Text);

            if (Matching == false ||
                txt_registerfirstName.Text == "" ||
                txt_registerlastName.Text == "")
            { MessageBox.Show("Please fill in the empyty fields or Check your ID Number Format"); } 
            else {

                string studentID = maskedtxt_registerstudentID.Text;
                string studentFirstName = txt_registerfirstName.Text;
                string studentLastName = txt_registerlastName.Text;
                string deptType = Convert.ToString(comboBox_dept.SelectedItem);
                string enrollmentType;

                if (rb_registerenrollType1.Checked)
                { enrollmentType = "Full Time"; }
                else { enrollmentType = "Part Time"; }

                StudentInfo studentinfo = new StudentInfo(studentID, studentFirstName, studentLastName, deptType, enrollmentType);
                newStudentAdded(this, studentinfo);
                this.Close();
            }
    }

        private void button_resetStudent_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox_registerstudentInfo.Controls)
            {
                if (c is TextBox || c is MaskedTextBox)
                {
                    c.Text = "";
                }
                maskedtxt_registerstudentID.Focus();
            }
        }

        private void groupBox_registerstudentInfo_Enter(object sender, EventArgs e)
        {

        }

        private void txt_registerfirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txt_registerlastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void button_resetStudent_CursorChanged(object sender, EventArgs e)
        {

        }

        private void maskedtxt_registerstudentID_KeyDown(object sender, KeyEventArgs e)
        {
            button_addStudent.Enabled = true;
            button_resetStudent.Enabled = true;
        }

        private void txt_registerfirstName_KeyDown(object sender, KeyEventArgs e)
        {
            button_addStudent.Enabled = true;
            button_resetStudent.Enabled = true;
        }

        private void txt_registerlastName_KeyDown(object sender, KeyEventArgs e)
        {
            button_addStudent.Enabled = true;
            button_resetStudent.Enabled = true;
        }
    }
}
