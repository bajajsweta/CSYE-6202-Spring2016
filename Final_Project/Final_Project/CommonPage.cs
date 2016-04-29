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
    public partial class CommonPage : Form
    {
         
        public CommonPage()
        {
            InitializeComponent();
            Depart_comboBox.CustomFormat = "yyyy-MM-dd";
            init();
        }

        public void init()
        {
            var paramValues = new List<string>();

            var paramTypes = new List<string>();
            
            FlightScheduleDataAccess fsda = new FlightScheduleDataAccess();

            FlightFrom_comboBox.DataSource = fsda.GetAllflightFromList().ConvertAll(fs => fs.FlighFrom);

            FlightTo_comboBox.DataSource = fsda.GetAllflightToList().ConvertAll(fs => fs.FlightTo);

            seatType_CombBox.DataSource = fsda.GetAllSeatTypes().ConvertAll(fs => fs.seat_type);
        }


        public String GetValue(String val)
        {
            if (!val.Trim().Equals(""))
                return val;
            return null;
        }

        private void button2_Click(object sender, EventArgs e) 
        {
            FlightSchedule fs = new FlightSchedule();
            fs.FlighFrom = FlightFrom_comboBox.SelectedItem.ToString();
            fs.FlightTo = FlightTo_comboBox.SelectedItem.ToString();
            fs.FlightDepartureTime = Depart_comboBox.Value;
            fs.FlightNumberOfSeats = No_of_seats_textbox.Text.Trim().Equals("") ? 0 : int.Parse(No_of_seats_textbox.Text);
            fs.seat_type = seatType_CombBox.SelectedItem.ToString();

            FlightScheduleDataAccess fsda = new FlightScheduleDataAccess();
            var listOfFlightSchedules = fsda.SearchFlightSchedule(fs);


            var dataTable = FlightSchedule.GetDataTable(listOfFlightSchedules);
            dgv_CommonTable.DataSource = dataTable;
            if (dataTable.Rows.Count >= 1)
                dgv_CommonTable.Columns[0].Visible = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            LoginPage loginpanel = new LoginPage();
            loginpanel.Show();
          
        }
    }
}
