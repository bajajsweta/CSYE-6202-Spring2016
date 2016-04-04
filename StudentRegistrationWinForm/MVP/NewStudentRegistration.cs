using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP
{
    public partial class NewStudentRegistration : Form
    {
        public event EventHandler newStudentAdded;
        private List<StudentInfo> students;
        private List<string> deptType;

        public NewStudentRegistration(List<StudentInfo> students)
        {
            InitializeComponent();
            this.students = students;
            comboBox_dept.DataSource = fillDeptType();
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

        private void button_addStudent_Click(object sender, EventArgs e)
        {
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

        private void button_resetStudent_Click(object sender, EventArgs e)
        {
            foreach (Control c in groupBox_registerstudentInfo.Controls)
            {
                if (c is TextBox || c is MaskedTextBox)
                {
                    c.Text = "";
                }
                
            }
        }

        private void groupBox_registerstudentInfo_Enter(object sender, EventArgs e)
        {

        }
    }
}
