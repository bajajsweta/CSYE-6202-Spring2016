using MVP;
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
    public partial class StudentRegistrationMainWindow : Form
    {

        DataLoad dl = new DataLoad();


        public StudentRegistrationMainWindow()
        {
            InitializeComponent();
            dgv_studentInfo.DataSource = dl.loadlist();
        }

        private void button_newStudent_Click(object sender, EventArgs e)
        {
            NewStudentRegistration newStudent = new NewStudentRegistration();
            newStudent.newStudentAdded += NewStudent_newStudentAdded;
            newStudent.Show();
        }

        private void NewStudent_newStudentAdded(object sender, EventArgs e)
        {
            StudentInfo student = e as StudentInfo;
            if (student != null)
            {
                dgv_studentInfo.DataSource = null;
                dl.students.Add(student);
                dgv_studentInfo.DataSource = dl.students;
            }
        }

        private void button_removeStudent_Click(object sender, EventArgs e)
        {
            bool rowindex = dgv_studentInfo.CurrentRow.Selected;

            StudentInfo studentinfo = (StudentInfo)dgv_studentInfo.CurrentRow.DataBoundItem;

            if (rowindex)
            {
                   RemoveStudent removeStudent = new RemoveStudent(studentinfo);
                   removeStudent.removeStudent += RemoveStudent_removeStudent;
                   removeStudent.Show();
            }
            else
            {
                MessageBox.Show("Please Select a Row");
            }

        }

            private void RemoveStudent_removeStudent(object sender, EventArgs e)
             {
                 StudentInfo student = e as StudentInfo;
                 if (student != null)
                 {
                     dgv_studentInfo.DataSource = null;
                     dl.students.Remove(student);
                     dgv_studentInfo.DataSource = dl.students;
                 }
             }
   

        private void StudentRegistrationMainWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void button_editStudent_Click(object sender, EventArgs e)
        {
            bool rowindex = dgv_studentInfo.CurrentRow.Selected;

            StudentInfo studentinfo = (StudentInfo)dgv_studentInfo.CurrentRow.DataBoundItem;

            if (rowindex)
            {
                EditStudent editStudent = new EditStudent(studentinfo);
                editStudent.editStudent += EditStudent_editStudent;
                editStudent.Show();
            }
            else
            {
                MessageBox.Show("Please Select a Row");
            }
        }

        private void EditStudent_editStudent(object sender, EventArgs e)
        {
            StudentInfo student = e as StudentInfo;
            if (student != null)
            {
                dgv_studentInfo.DataSource = null;
                dgv_studentInfo.DataSource = dl.students;
            }
        }

        private void dgv_studentInfo_MouseEnter(object sender, EventArgs e)
        {

            StudentInfo studentinfo = (StudentInfo)dgv_studentInfo.CurrentRow.DataBoundItem;

            maskedTextBox_studentid.Text = studentinfo.StudentID;
            txt_firstName.Text = studentinfo.StudentFirstName;
            txt_lastName.Text = studentinfo.StudentLastName;
            comboBox_deptread.Text = studentinfo.DeptType;
            if (studentinfo.EnrollmentType == "Full Time")
            { rb_enrollType1.Checked = true; }
            else { rb_enrollType2.Checked = true; }
        }

    }
}
