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
    public partial class RemoveStudent : Form
    {
        /* public event EventHandler removeStudent;*/
        public event EventHandler removeStudent;
        public StudentInfo student;

        public RemoveStudent(StudentInfo student)
        {
            InitializeComponent();
            this.student = student;
         
            loadGroup();
        }

            public void loadGroup() {
            maskedtxt_removestudentID.Text = student.StudentID;
            txt_removefirstName.Text = student.StudentFirstName;
            txt_removelastName.Text = student.StudentLastName;
            comboBox_removedept.Text = student.DeptType;
            if (student.EnrollmentType == "Full Time")
            { rb_removeenrollType1.Checked = true; }
            else { rb_removeenrollType2.Checked = true; }
        }

        private void button_addStudent_Click(object sender, EventArgs e)
        {           
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove?", "Remove Student", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                removeStudent(this, student);
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Close();
            }
        }

        private void button_resetStudent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox_registerstudentInfo_Enter(object sender, EventArgs e)
        {

        }

        private void RemoveStudent_Load(object sender, EventArgs e)
        {

        }
    }
}
