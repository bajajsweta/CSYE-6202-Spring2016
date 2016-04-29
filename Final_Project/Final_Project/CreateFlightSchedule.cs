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
    public partial class CreateFlightSchedule : Form
    {

        private FlightSchedule fs;
        private Flight flight;
        List<Employee> employees;
        AdminPage adminPage;

        public void SetCrewList()
        {
            crewNumber_comboBox.DataSource = employees.ConvertAll(e => "Crew : " + e.crew_id.ToString()).Distinct().ToList().Where(l => !l.Equals("Crew : 0")).ToList();

            if(fs != null)
            {
                crewNumber_comboBox.SelectedItem = "Crew : " + fs.Crew_Id.ToString();
            }
        }

        public CreateFlightSchedule(AdminPage adminPage, FlightSchedule fs, List<Employee> crew, Flight flight)
        {
            this.employees = crew;
            this.fs = fs;
            this.flight = flight;
            this.adminPage = adminPage;
            InitializeComponent();
            SetCrewList();

            if (fs == null)
                textBox1.Text = "Create Flight Schedule";
            else
                textBox1.Text = "Update Flight Schedule";
            init();

        }

        public void init()
        {

            FlightDataAccess fda = new FlightDataAccess();
            var flightname = fda.getAllFlights(new Flight()).ConvertAll(f => f.Name);
            flightname_Combobox.DataSource = flightname;
            FlightScheduleDataAccess fsda = new FlightScheduleDataAccess();
            flightFrom_comboBox.DataSource = fsda.GetFlightLocations();
            flightTo_comboBox.DataSource = fsda.GetFlightLocations();

            if (flight.Name != null && !flight.Name.Equals(""))
            {
                flightname_Combobox.SelectedItem = flight.Name;
            }

            if(fs != null)
            {
                flightFrom_comboBox.SelectedItem = fs.FlighFrom;
                flightTo_comboBox.SelectedItem = fs.FlightTo;
                dateTimePickerFrom.Value = fs.FlightDepartureTime;
                dateTimePickerTo.Value = fs.FlightArrival;
                BusinessType_SeatCount.Text = fs.Type_seatCount.ToString();

            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FlightSchedule fschedule = new FlightSchedule();
            fschedule.FlightName = flightname_Combobox.SelectedItem.ToString();
            fschedule.FlighFrom = flightFrom_comboBox.SelectedItem.ToString();
            fschedule.FlightTo = flightTo_comboBox.SelectedItem.ToString();
            fschedule.FlightDepartureTime = Convert.ToDateTime(dateTimePickerFrom.Text);
            fschedule.FlightArrival = Convert.ToDateTime(dateTimePickerTo.Text);
            fschedule.Type_seatCount = Convert.ToInt32(BusinessType_SeatCount.Text);
            fschedule.Crew_Id = int.Parse(crewNumber_comboBox.SelectedItem.ToString().Substring(crewNumber_comboBox.SelectedItem.ToString().IndexOf(":") + 1));
            fschedule.seat_type = "Business";
            


            if (fs == null)
            {
                FlightScheduleDataAccess fsda = new FlightScheduleDataAccess();
                fsda.CreateFlightSchedule(fschedule);
                adminPage.AddToFlightScheduleGrid(fschedule);
            }
            else
            {
                fschedule.FlightScheduleID = fs.FlightScheduleID;
                fschedule.FlightCarrier = fs.FlightCarrier;
                fschedule.FlightNumberOfSeats = fs.FlightNumberOfSeats;

                FlightScheduleDataAccess fsda = new FlightScheduleDataAccess();
                fsda.UpdateFlightSchedule(fschedule);
                adminPage.UpdateFlightScheduleGrid(fschedule);

            }



        }

        private void crewNumber_comboBox_SelectedIndexChanged(object sender, EventArgs er)
        {
            int selectedCrewId = int.Parse(crewNumber_comboBox.SelectedItem.ToString().Substring(crewNumber_comboBox.SelectedItem.ToString().IndexOf(":") + 1));

            var empList = employees.Where(e => e.crew_id == selectedCrewId).ToList();

            var table = Employee.GetDataTable(empList);
            dgv_CrewMembers.DataSource = table;
        }
    }
}
