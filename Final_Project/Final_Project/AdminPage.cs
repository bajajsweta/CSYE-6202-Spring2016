﻿using Final_Project.DAL;
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
    public partial class AdminPage : Form
    {
        DAL.DataAccess da = new DAL.DataAccess();

        Flight flight;
        Employee employee;
        FlightSchedule flightSchedule;

        List<string> paramValues = new List<string>();
        List<string> paramTypes = new List<string>();


        List<FlightSchedule> allFlightSchedules = new List<FlightSchedule>();
        List<Flight> allFlights = new List<Flight>();
        List<Employee> allCrew = new List<Employee>();

        public AdminPage()
        {
            InitializeComponent();
            flight = new Flight();
            employee = new Employee();
            flightSchedule = new FlightSchedule();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateFlightPage page = new CreateFlightPage(this, null);
            page.Show();
        }

        /***************************************Flight Related Code************************/

        public void PopulateAllFlightsGrid()
        {
            var dataTable = Flight.GetDataTable(allFlights);
            dgv_flightdetails.DataSource = dataTable;
            if (dataTable.Rows.Count >= 1)
            dgv_flightdetails.Columns[0].Visible = false;
        }

        public void AddToFlightGrid(Flight f)
        {
            allFlights.Add(f);
            PopulateAllFlightsGrid();
        }

        public void UpdateFlightGrid(Flight flight)
        {
            allFlights.RemoveAll(f => f.Id == flight.Id);
            AddToFlightGrid(flight);
        }

        public void DeleteFromFlightGrid(Flight flight)
        {
            allFlights.RemoveAll(f => f.Id == flight.Id);
            PopulateAllFlightsGrid();
        }

     /***************************************FlightSchedule Related Code************************/

        public void PopulateAllFlightScheduleGrid()
        {
            allFlightSchedules.Sort((f1, f2) => f1.FlightScheduleID < f2.FlightScheduleID ? 1 : 
                (f1.FlightScheduleID == f2.FlightScheduleID ? 0 : -1));

            var dataTable = FlightSchedule.GetDataTable(allFlightSchedules);
            dgv_flightScheduleDetails.DataSource = dataTable;
            if (dataTable.Rows.Count >= 1)
                dgv_flightScheduleDetails.Columns[0].Visible = false;
        }

        public void AddToFlightScheduleGrid(FlightSchedule flightSchedule)
        {
            allFlightSchedules.Add(flightSchedule);
            PopulateAllFlightScheduleGrid();
        }

        public void UpdateFlightScheduleGrid(FlightSchedule flightSchedule)
        {
            allFlightSchedules.RemoveAll(fs => fs.FlightScheduleID == flightSchedule.FlightScheduleID && fs.seat_type.Equals(flightSchedule.seat_type));
            var otherFs = allFlightSchedules.First(fs => fs.FlightScheduleID == flightSchedule.FlightScheduleID && !fs.seat_type.Equals(flightSchedule.seat_type));
            otherFs.Type_seatCount = flightSchedule.FlightNumberOfSeats - flightSchedule.Type_seatCount;
            otherFs.Crew_Id = flightSchedule.Crew_Id;
            otherFs.FlightName = flightSchedule.FlightName;
            otherFs.FlightCarrier = flightSchedule.FlightCarrier;
            otherFs.FlighFrom = flightSchedule.FlighFrom;
            otherFs.FlightTo = flightSchedule.FlightTo;
            otherFs.FlightDepartureTime = flightSchedule.FlightDepartureTime;
            otherFs.FlightArrival = flightSchedule.FlightArrival; 

            AddToFlightScheduleGrid(flightSchedule);
        }

        public void DeleteFromFlightScheduleGrid(FlightSchedule flightSchedule)
        {
            allFlightSchedules.RemoveAll(fs => fs.FlightScheduleID == flightSchedule.FlightScheduleID);
            PopulateAllFlightScheduleGrid();
        }



        /***********************************Employee Related Code******************************/
        public void PopulateAllCrewGrid()
        {
            var dataTable = Employee.GetDataTable(allCrew);
            dgv_CrewDetails.DataSource = dataTable;
            if (dataTable.Rows.Count >= 1)
                dgv_CrewDetails.Columns[0].Visible = false;
        }

        public void AddToCrewGrid(Employee employee)
        {
            allCrew.Add(employee);
            PopulateAllCrewGrid();
        }

        public void UpdateCrewGrid(Employee employee)
        {
            allCrew.RemoveAll(e => e.ID == employee.ID);
            AddToCrewGrid(employee);
        }

        public void DeleteFromCrewGrid(Employee employee)
        {
            allCrew.RemoveAll(e => e.ID == employee.ID);
            PopulateAllCrewGrid();
        }
        /***********************************Employee Related Code******************************/

        private void AdminPage_Load(object sender, EventArgs e)
        {
            var af = new FlightDataAccess().getAllFlights(flight);
            allFlights = af;

            PopulateAllFlightsGrid();

            var ee = new FlightCrewDataAccess().CrewList(employee);
            allCrew = ee;

            PopulateAllCrewGrid();


            allFlightSchedules = new FlightScheduleDataAccess().SearchFlightSchedule(null);
            PopulateAllFlightScheduleGrid();
        }

        private void flightSchedule_rb_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void flightEdit_rb_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Flight flightdetails = allFlights[dgv_flightdetails.SelectedRows[0].Index];

            CreateFlightPage page = new CreateFlightPage(this, flightdetails);
            page.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Flight flightdetails = allFlights[dgv_flightdetails.SelectedRows[0].Index];
            FlightDataAccess fda = new FlightDataAccess();
            fda.deleteFlight(flightdetails);
            DeleteFromFlightGrid(flightdetails);
        }

        private void dgv_details_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            CreateEmployeePage ep = new CreateEmployeePage(this,null);
            ep.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            Employee empDetails = allCrew[dgv_CrewDetails.SelectedRows[0].Index];
            CreateEmployeePage ep = new CreateEmployeePage(this, empDetails);
            ep.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Employee employeedetails = allCrew[dgv_CrewDetails.SelectedRows[0].Index];
            FlightCrewDataAccess fcda = new FlightCrewDataAccess();
            fcda.deleteFlightCrew(employeedetails);
            DeleteFromCrewGrid(employeedetails);
        }

        private void button5_Click(object sender, EventArgs e)
        {

            flight = new Flight();
            CreateFlightSchedule cfs = new CreateFlightSchedule(this,null,allCrew,flight);
            cfs.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var fs = allFlightSchedules[dgv_flightScheduleDetails.SelectedRows[0].Index];

            if (fs.seat_type.Equals("Economy"))
            {
                MessageBox.Show("Cannot Change Economy Class Seats!");
                return;
            }
            else
            {
                flight = new Flight();
                flight.Name = fs.FlightName;
                CreateFlightSchedule cfs = new CreateFlightSchedule(this, fs, allCrew, flight);
                cfs.Show();
            }

        }

        private void view_Button_Click(object sender, EventArgs e)
        {

        }

        private void delete_Button_Click(object sender, EventArgs e)
        {
            var fs = allFlightSchedules[dgv_flightScheduleDetails.SelectedRows[0].Index];

            FlightScheduleDataAccess fsda = new FlightScheduleDataAccess();
            fsda.DeleteFlightSchedule(fs);
            DeleteFromFlightScheduleGrid(fs);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
