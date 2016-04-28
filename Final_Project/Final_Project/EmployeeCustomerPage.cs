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
    public partial class EmployeeCustomerPage : Form
    {
        public EmployeeCustomerPage()
        {
            InitializeComponent();
            EmpDepart_comboBox.CustomFormat = "yyyy-MM-dd";
            init();
        }

        public void init()
        {
            var paramValues = new List<string>();

            var paramTypes = new List<string>();

            FlightScheduleDataAccess fsda = new FlightScheduleDataAccess();

            EmpFlightFrom_comboBox.DataSource = fsda.GetAllflightFromList().ConvertAll(fs => fs.FlighFrom);

            EmpFlightTo_comboBox.DataSource = fsda.GetAllflightToList().ConvertAll(fs => fs.FlightTo);

            EmpSeatType_comboBox.DataSource = fsda.GetAllSeatTypes().ConvertAll(fs => fs.seat_type);
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
            fs.FlighFrom = EmpFlightFrom_comboBox.SelectedItem.ToString();
            fs.FlightTo = EmpFlightTo_comboBox.SelectedItem.ToString();
            fs.FlightDepartureTime = EmpDepart_comboBox.Value;
            fs.FlightNumberOfSeats = EmpNo_of_seats_textbox.Text.Trim().Equals("") ? 0 : int.Parse(EmpNo_of_seats_textbox.Text);
            fs.seat_type = EmpSeatType_comboBox.SelectedItem.ToString();

            FlightScheduleDataAccess fsda = new FlightScheduleDataAccess();
            var listOfFlightSchedules = fsda.SearchFlightSchedule(fs);


            var dataTable = FlightSchedule.GetDataTable(listOfFlightSchedules);
            dgv_CommonTable.DataSource = dataTable;
            if (dataTable.Rows.Count >= 1)
                dgv_CommonTable.Columns[0].Visible = false;
        
    }


        private void dgv_CommonTable_MouseEnter(object sender, EventArgs e)
        {      
        }

        private void dgv_CommonTable_MouseClick(object sender, MouseEventArgs e)
        {
            bool rowindex = dgv_CommonTable.CurrentRow.Selected;

            if (!rowindex)
            {
                MessageBox.Show("Please Select a Row");
                return;
            }

            var flightScheduleId = Convert.ToInt32(dgv_CommonTable.CurrentRow.Cells[0].Value);

            FlightScheduleDataAccess fsda = new FlightScheduleDataAccess();
            var flightSchedules = fsda.GetFlightScheduleID(flightScheduleId);
            var flightSchedule = flightSchedules.First(f => f.seat_type.Equals(EmpSeatType_comboBox.Text));


            int numOfSeatsSelected = int.Parse(EmpNo_of_seats_textbox.Text.Equals("") ? "0" : EmpNo_of_seats_textbox.Text);
            EmployeeBookTicket empbookTicket = new EmployeeBookTicket(flightSchedule, numOfSeatsSelected);
            empbookTicket.Show();
        }



        private void refreshbutton_Click(object sender, EventArgs e)
        {
            DAL.DataAccess da = new DAL.DataAccess();

            var paramValues = new List<string>();
            paramValues.Add("Johny Cash");

            var paramTypes = new List<string>();
            paramTypes.Add("string");

            var bookingList = da.runProcedure("BOOKED_TICKETS", paramValues, paramTypes);

            var table = da.GetDataTableFor(bookingList);


            dgv_bookedTickets.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
