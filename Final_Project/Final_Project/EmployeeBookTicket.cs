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
    public partial class EmployeeBookTicket : Form
    {
        public FlightSchedule fs;

        public int numOfSeatsSelected;
        EmployeeCustomerPage employeeCustomerPage;

        public EmployeeBookTicket(EmployeeCustomerPage employeeCustomerPage,FlightSchedule fs, int numOfSeatsSelected)
        {
    
            InitializeComponent();
            this.employeeCustomerPage = employeeCustomerPage;
            this.fs = fs;
            this.numOfSeatsSelected = numOfSeatsSelected;
            Fillflightform();
            init();
           
        }

        public void init()
        {
            DAL.DataAccess da = new DAL.DataAccess();

            var paramValues = new List<string>();

            var paramTypes = new List<string>();

            var Customer_FormFill = da.runProcedure("SELECT_CUSTOMER", paramValues, paramTypes);
            var CustomerNameList = Customer_FormFill.ConvertAll(l => l[0].ToString());

            Customer_ComboBox.DataSource = CustomerNameList;

         
        }


        private void Fillflightform() {
            flightNametxt.Text = fs.FlightName;
            flightCarrierTxt.Text = fs.FlightCarrier;
            NoOfSeatstxt.Text = Convert.ToString(fs.FlightNumberOfSeats);
            Flightfrom_comboBox.Text = fs.FlighFrom;
            flightTo_comboBox.Text = fs.FlightTo;
            DepartureTime_comboBox.Text = Convert.ToString(fs.FlightDepartureTime);
            ArrivalTime_comboBox.Text = Convert.ToString(fs.FlightArrival);
            flightDuration_txt.Text = Convert.ToString(fs.FlightDuration);
            priceTxt.Text = Convert.ToString(fs.Type_seatCost);
            seatType_txt.Text = fs.seat_type;
            saetsBookedNumber.Text = Convert.ToString(numOfSeatsSelected);
        }

        private void EmployeeBookTicket_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(saetsBookedNumber.Text) > Convert.ToInt32(NoOfSeatstxt.Text))
            {
                MessageBox.Show("Please Change your Seat Selection Criteria, We are short of seats!");
                return;
            }
            Booking booking = new Booking();
            booking.FlightScheduleID = fs.FlightScheduleID;
            booking.CustomerName = Customer_ComboBox.SelectedValue.ToString();
            booking.EmployeeName = CommonAttributes.GetInstance().EmployeeName;
            booking.seats_booked = Convert.ToInt32(saetsBookedNumber.Text);
            booking.SeatType = fs.seat_type;
            booking.Cost = fs.Type_seatCost;
            booking.TotalCost =  float.Parse(totalPriceTxt.Text);
            booking.FlightName = flightNametxt.Text;
            booking.Carrier = flightCarrierTxt.Text;
            booking.FlighFrom = Flightfrom_comboBox.Text;
            booking.FlightTo = flightTo_comboBox.Text;
            booking.FlightDepartureTime = Convert.ToDateTime(DepartureTime_comboBox.Text);
            booking.FlightArrivalTime = Convert.ToDateTime(ArrivalTime_comboBox.Text);
            booking.FlightDuration = Convert.ToInt32(flightDuration_txt.Text);
            booking.BookingTime = DateTime.Now;


            BookingDataAccess bda = new BookingDataAccess();
            booking = bda.CreateBooking(booking);
            

            employeeCustomerPage.AddToBookingGrid(booking);

            MessageBox.Show("Thank you for Booking !");
            this.Close();
        }

        private void saetsBookedNumber_TextChanged(object sender, EventArgs e)
        {
            if(!saetsBookedNumber.Text.Equals(""))
                totalPriceTxt.Text = "" + (fs.Type_seatCost) * float.Parse(saetsBookedNumber.Text);
        }
    }
}
