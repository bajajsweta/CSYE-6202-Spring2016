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

        ISeat seat;
        List<Booking> allBookings = new List<Booking>();

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


            Employee e = new Employee();
            e.Name = ConstantAttributes.GetInstance().EmployeeName;
            allBookings = new BookingDataAccess().GetAllBookings(e);
            PopulateAllBookingsGrid();

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

            if (flightSchedule.seat_type.Equals("Business"))
            {
                seat = new BusinessSeat();
            }
            else
            {
                seat = new EconomySeat();
            }

            flightSchedule.Type_seatCost = seat.CalculatePrice(flightSchedule);

            int numOfSeatsSelected = int.Parse(EmpNo_of_seats_textbox.Text.Equals("") ? "0" : EmpNo_of_seats_textbox.Text);
            EmployeeBookTicket empbookTicket = new EmployeeBookTicket(this,flightSchedule, numOfSeatsSelected);
            empbookTicket.Show();
        }



        private void refreshbutton_Click(object sender, EventArgs e)
        {
        }

        /***************************************BookingGrid Related Code************************/

        public void PopulateAllBookingsGrid()
        {
            var dataTable = Booking.GetDataTable(allBookings);
            dgv_bookedTickets.DataSource = dataTable;
            if (dataTable.Rows.Count >= 1)
                dgv_bookedTickets.Columns[0].Visible = false;
        }

        public void AddToBookingGrid(Booking booking)
        {
            allBookings.Add(booking);
            PopulateAllBookingsGrid();
        }

        public void UpdateBookingGrid(Booking booking)
        {
            allBookings.RemoveAll(b => b.BookingID == booking.BookingID);
            AddToBookingGrid(booking);
        }

        public void DeleteFromBookingGrid(Booking booking)
        {
            allBookings.RemoveAll(b => b.BookingID == booking.BookingID);
            PopulateAllBookingsGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Booking booking = allBookings[dgv_bookedTickets.SelectedRows[0].Index];
            // code vto call BookingDataAccess
            BookingDataAccess bda = new BookingDataAccess();
            bda.DeleteBooking(booking);
            DeleteFromBookingGrid(booking);
        }

        private void dgv_CommonTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
