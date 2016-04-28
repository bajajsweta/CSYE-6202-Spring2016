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

        public EmployeeBookTicket(FlightSchedule fs, int numOfSeatsSelected)
        {
            InitializeComponent();
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
            priceTxt.Text = Convert.ToString(fs.price);
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

            DAL.DataAccess da = new DAL.DataAccess();

            var paramValues = new List<string>();
            paramValues.Add(Convert.ToString(fs.FlightScheduleID));
            paramValues.Add(Customer_ComboBox.SelectedItem.ToString());
            paramValues.Add(CommonAttributes.GetInstance().EmployeeName);
         //   paramValues.Add(fs.price_id.ToString());
            paramValues.Add("1");
            paramValues.Add(saetsBookedNumber.Text);
          
            var paramTypes = new List<string>();
            paramTypes.Add("int");
            paramTypes.Add("string");
            paramTypes.Add("string");
           // paramTypes.Add("int");
            paramTypes.Add("int");
            paramTypes.Add("int");

            var Customer_FormFill = da.runProcedure("BOOKING_TICKET", paramValues, paramTypes);
            MessageBox.Show("Thank you for Booking !");
            this.Close();
        }
    }
}
