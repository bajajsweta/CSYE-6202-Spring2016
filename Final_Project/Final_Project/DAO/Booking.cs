using System;
using System.Collections.Generic;
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


        public static Booking construct(List<object> list)
        {
            Booking booking = new Booking();
            booking.BookingID = (int)list[0];
            booking.FlightName = list[1].ToString();
            booking.Carrier = list[2].ToString();
            booking.NumberOfSeats = (int)list[3];
            booking.FlighFrom = list[4].ToString();
            booking.FlightTo = list[5].ToString();
            booking.FlightDepartureTime = (DateTime)list[6];
            booking.FlightArrivalTime = (DateTime)list[7];
            booking.SeatType = list[8].ToString();
            booking.EmployeeName = list[9].ToString();
            booking.CustomerName = list[10].ToString();
            booking.Cost = (float)list[11];
            booking.TotalCost = (float)list[12];
            booking.BookingTime = (DateTime)list[13];
            booking.seats_booked = (int)list[14];
            return booking;
        }
    }
}
