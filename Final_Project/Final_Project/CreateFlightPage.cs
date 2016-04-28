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
    public partial class CreateFlightPage : Form
    {
        Flight flight;
        AdminPage adminPage;

        public CreateFlightPage(AdminPage adminPage, Flight flight)
        {
            this.adminPage = adminPage;
            this.flight = flight;
            InitializeComponent();


            if(flight == null)
            {
                textBox1.Text = "Create new Flight";
            } else
            {
                textBox1.Text = "Update Flight";
                PopulateFromFlight();
            }

        }

        public void PopulateFromFlight()
        {
            flightname_txt.Text = flight.Name;
            flightcarrier_txt.Text = flight.Carrier;
            noOfSeats_txt.Text = "" + flight.NumberOfSeats;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Flight f = new Flight();            
            f.Name = flightname_txt.Text;
            f.Carrier = flightcarrier_txt.Text;
            f.NumberOfSeats = Convert.ToInt32(noOfSeats_txt.Text);

            FlightDataAccess fda = new FlightDataAccess();
            if (flight == null)
            {
                f = fda.createFlight(f);
                adminPage.AddToFlightGrid(f);
            }
            else
            {
                f.Id = flight.Id;
                fda.updateFlight(f);
                adminPage.UpdateFlightGrid(f);
            }


            
            this.Close();
        }

        private void noOfSeats_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void flightcarrier_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void flightname_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateFlightPage_Load(object sender, EventArgs e)
        {

        }
    }
}
