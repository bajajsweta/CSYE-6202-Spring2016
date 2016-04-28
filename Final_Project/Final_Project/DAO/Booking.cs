using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DAO
{
    public class Booking
    {
        int BookingID { get; set; }
        string FlightName { get; set; }
        string Carrier { get; set; }
        int NumberOfSeats { get; set; }
        int FlightScheduleID { get; set; }
        string FlighFrom { get; set; }
        string FlightTo { get; set; }
        DateTime FlightDepartureTime { get; set; }
        DateTime FlightArrivalTime { get; set; }
        float FlightDuration { get; set; }
        string SeatType { get; set; }
        int EmployeeID { get; set; }
        string EmployeeName { get; set; }
        string EmployeeDesignation { get; set; }
        int EmployeeAge { get; set; }
        string EmployeeGender { get; set; }
        string Employeeph { get; set; }
        int CustomerID { get; set; }
        string CustomerName { get; set; }
        string CustomerSex { get; set; }
        int CustomerAge { get; set; }
        string CustomerIDProof { get; set; }
        string CustomerIsPassenger { get; set; }
        int PriceID { get; set; }
        string Cost { get; set; }
        DateTime BookingTime { get; set; }
        string PaymentMode { get; set; }
        int seats_booked { get; set; }


        public Booking construct(List<object> list)
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
            booking.EmployeeDesignation = list[10].ToString();
            booking.EmployeeAge = (int)list[11];
            booking.EmployeeGender = list[12].ToString();
            booking.Employeeph = list[13].ToString();
            booking.CustomerName = list[14].ToString();
            booking.CustomerSex = list[15].ToString();
            booking.CustomerAge = (int)list[16];
            booking.CustomerIDProof = list[17].ToString();
            booking.CustomerIsPassenger = list[18].ToString();
            booking.Cost = list[19].ToString();
            booking.BookingTime = (DateTime)list[20];
            booking.PaymentMode = list[21].ToString();
            booking.seats_booked = (int)list[22];
            return booking;
        }
    }
}
