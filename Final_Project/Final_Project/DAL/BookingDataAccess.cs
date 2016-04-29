using Final_Project.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DAL
{
    class BookingDataAccess : DataAccess
    {
        public Booking CreateBooking(Booking booking)
        {
            var paramValues = new List<string>();
            paramValues.Add(GetValue(booking.FlightScheduleID.ToString()));
            paramValues.Add(GetValue(booking.CustomerName));
            paramValues.Add(GetValue(booking.EmployeeName));
            paramValues.Add(GetValue(booking.seats_booked.ToString()));
            paramValues.Add(GetValue(booking.SeatType));
            paramValues.Add(GetValue(booking.Cost.ToString()));
            paramValues.Add(GetValue(booking.TotalCost.ToString()));

            var paramTypes = new List<string>();
            paramTypes.Add("int");
            paramTypes.Add("string");
            paramTypes.Add("string");
            paramTypes.Add("int");
            paramTypes.Add("string");
            paramTypes.Add("float");
            paramTypes.Add("float");

            //Enter the Stored proc for the Employee
            var bookingIDAsList = runProcedure("BOOKING_TICKET", paramValues, paramTypes);

            var bookingId = int.Parse(bookingIDAsList[0][0].ToString());
            booking.BookingID = bookingId;


            return booking;
        }

    }
}
