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
    public partial class EditStudent : Form
    {
        public event EventHandler editStudent;
        StudentInfo student;
        private List<string> deptType;

        public EditStudent(StudentInfo student)
        {
            InitializeComponent();
            this.student = student;
            comboBox_deptedit.DataSource = fillDeptType();
            loadGroup();
        }

        public void loadGroup()
        {
            maskedtxt_editstudentID.Text = student.StudentID;
            txt_editfirstName.Text = student.StudentFirstName;
            txt_editlastName.Text = student.StudentLastName;
            comboBox_deptedit.Text = student.DeptType;
            if (student.EnrollmentType == "Full Time")
            { rb_editenrollType1.Checked = true; }
            else { rb_editenrollType2.Checked = true; }
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

        private void button_editStudent_Click(object sender, EventArgs e)
        {
            student.StudentID = maskedtxt_editstudentID.Text;
            student.StudentFirstName = txt_editfirstName.Text;
            student.StudentLastName = txt_editlastName.Text;
            student.DeptType = Convert.ToString(comboBox_deptedit.SelectedItem);

            if (rb_editenrollType1.Checked)
            { student.EnrollmentType = "Full Time"; }
            else { student.EnrollmentType = "Part Time"; }


            DialogResult dialogResult = MessageBox.Show("Are you sure you want to update information?", "Update Student", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                editStudent(this, student);
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Close();
            }
        }

        private void button_cancelStudent_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /////////////////////////////////////////////////////////////////////
    }
}
