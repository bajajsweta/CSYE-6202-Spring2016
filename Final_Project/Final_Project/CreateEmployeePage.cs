using Final_Project.DAL;
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
    public partial class CreateEmployeePage : Form
    {
        Employee employee;
        AdminPage adminPage;

        public CreateEmployeePage(AdminPage adminPage, Employee employee)
        {
            this.employee = employee;
            this.adminPage = adminPage;
            InitializeComponent();

            if (employee == null)
            {
                textBox1.Text = "Create new Employee Record";
            }
            else
            {
                textBox1.Text = "Update Employee Record";
                PopulateFromEmployee();
            }

        }

        public void PopulateFromEmployee()
        {
            empName_txt.Text = employee.Name;
            empAge_txt.Text = "" + employee.Age;
            empGender_txt.Text = employee.Gender;
            empDesignation_txt.Text = employee.Designation;
            empEmail_txt.Text = employee.Email;
            empPassword_txt.Text = employee.Password;
            crewID_txt.Text = "" + employee.crew_id;
        }


        private void button1_Click(object sender, EventArgs ea)
        {
            Employee e = new Employee();
            e.Name = empName_txt.Text;
            e.Age = Convert.ToInt32(empAge_txt.Text);
            e.Gender = empGender_txt.Text;
            e.Designation = empDesignation_txt.Text;
            e.Email = empEmail_txt.Text;
            e.Password = empPassword_txt.Text;
            e.crew_id = Convert.ToInt32(crewID_txt.Text);

            FlightCrewDataAccess fcda = new FlightCrewDataAccess();  

       
            if (employee == null)
            {
                e = fcda.createFlightCrew(e);
                adminPage.AddToCrewGrid(e);
            }
            else
            {
                e.ID = employee.ID;
                fcda.updateFlightCrew(e);
                adminPage.UpdateCrewGrid(e);
            }



            this.Close();
        }
    }
}
