using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DAO
{
    public class Booking
    {
       public int BookingID { get; set; }
        public string FlightName { get; set; }
        public string Carrier { get; set; }
        public int NumberOfSeats { get; set; }
        public int FlightScheduleID { get; set; }
        public string FlighFrom { get; set; }
        public string FlightTo { get; set; }
        public DateTime FlightDepartureTime { get; set; }
        public DateTime FlightArrivalTime { get; set; }
        public float FlightDuration { get; set; }
        public string SeatType { get; set; }
        public string EmployeeName { get; set; }
        public string CustomerName { get; set; }
        public float Cost { get; set; }
        public float TotalCost { get; set; }
        public DateTime BookingTime { get; set; }
        public int seats_booked { get; set; }



        public static DataTable GetDataTable(List<Booking> list)
        {
            DataTable table = new DataTable();

            if (list.Count == 0)
                return table;


            table.Columns.Add(new DataColumn("Booking"));
            table.Columns.Add(new DataColumn("Booking Time"));
            table.Columns.Add(new DataColumn("Employee Name"));
            table.Columns.Add(new DataColumn("Customer Name"));
            table.Columns.Add(new DataColumn("Flight Name"));
            table.Columns.Add(new DataColumn("Flight Carrier"));
            table.Columns.Add(new DataColumn("Flight From"));
            table.Columns.Add(new DataColumn("Flight To"));
            table.Columns.Add(new DataColumn("Flight Departure Time"));
            table.Columns.Add(new DataColumn("Flight Arrival Time"));
            table.Columns.Add(new DataColumn("Flight Duration"));
            table.Columns.Add(new DataColumn("Seat Type"));
            table.Columns.Add(new DataColumn("Seats Booked"));
            table.Columns.Add(new DataColumn("Cost per Ticket"));
            table.Columns.Add(new DataColumn("Total Cost"));

            list.ForEach(b => table.Rows.Add(new object[]{  b,
                                                            b.BookingTime,
                                                            b.EmployeeName,
                                                            b.CustomerName,
                                                            b.FlightName,
                                                            b.Carrier,
                                                            b.FlighFrom,
                                                            b.FlightTo,
                                                            b.FlightDepartureTime,
                                                            b.FlightArrivalTime,
                                                            b.FlightDuration,
                                                            b.SeatType,
                                                            b.seats_booked,
                                                            b.Cost,
                                                            b.TotalCost
                                                         }));
            return table;
        }


        public static Booking construct(List<object> list)
        {
            Booking booking = new Booking();
            booking.BookingID = (int)list[0];
            booking.FlightName = list[1].ToString();
            booking.Carrier = list[2].ToString();
           // booking.NumberOfSeats = (int)list[3];
            booking.FlighFrom = list[3].ToString();
            booking.FlightTo = list[4].ToString();
            booking.FlightDepartureTime = (DateTime)list[5];
            booking.FlightArrivalTime = (DateTime)list[6];
            booking.SeatType = list[7].ToString();
            booking.EmployeeName = list[8].ToString();
            booking.CustomerName = list[9].ToString();
            booking.Cost = (float)list[10];
            booking.TotalCost = (float)list[11];
            booking.BookingTime = (DateTime)list[12];
            booking.seats_booked = (int)list[13];
            booking.FlightDuration = int.Parse("" + list[14].ToString());
            return booking;
        }
    }
}
