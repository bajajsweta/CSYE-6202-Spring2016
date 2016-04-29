using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DAO
{
    public class FlightSchedule
    {
        private static ISeat seat;


        public int FlightScheduleID { get; set; }
        public int FlightID { get; set; }
        public string FlighFrom { get; set; }
        public string FlightTo { get; set; }
        public DateTime FlightDepartureTime { get; set; }
        public DateTime FlightArrival { get; set; }
        public float FlightDuration { get; set; }
        public string FlightName { get; set; }
        public string FlightCarrier { get; set; }
        public int FlightNumberOfSeats { get; set; }
        public float price { get; set; }
        public string seat_type { get; set; }
        //    public int price_id { get; set; }
        public int Type_seatCount { get; set; }
        // public int business_seatCount { get; set; }
        // public int economy_seatCount { get; set; }
        public int Crew_Id { get; set; }
        public float Type_seatCost { get; set; }


        public static DataTable GetDataTable(List<FlightSchedule> list)
        {
            DataTable table = new DataTable();

            if (list.Count == 0)
                return table;


            table.Columns.Add(new DataColumn("Flight Schedule"));
            table.Columns.Add(new DataColumn("Flight Carrier"));
            table.Columns.Add(new DataColumn("Flight Name"));
            table.Columns.Add(new DataColumn("Flight From"));
            table.Columns.Add(new DataColumn("Flight To"));
            table.Columns.Add(new DataColumn("Flight Departure"));
            table.Columns.Add(new DataColumn("Flight Arrival"));
            table.Columns.Add(new DataColumn("Flight Number of Seats"));
            //     table.Columns.Add(new DataColumn("Flight Price"));
            table.Columns.Add(new DataColumn("Flight SeatType"));
            table.Columns.Add(new DataColumn("Flight Seat Count"));
            table.Columns.Add(new DataColumn("Flight Seat Cost"));
            //   table.Columns.Add(new DataColumn("Flight Economy Seats"));
            table.Columns.Add(new DataColumn("Crew Id"));


         

            list.ForEach(f =>
            {
                if (f.seat_type.Equals("Business"))
                    seat = new BusinessSeat();
                else
                    seat = new EconomySeat();
                f.Type_seatCost = seat.CalculatePrice(f);
            });



            list.ForEach(fs => table.Rows.Add(new object[]{ fs.FlightScheduleID,
                                                            fs.FlightCarrier,
                                                            fs.FlightName,
                                                            fs.FlighFrom,
                                                            fs.FlightTo,
                                                            fs.FlightDepartureTime,
                                                            fs.FlightArrival,
                                                            fs.FlightNumberOfSeats,
                                                          //  fs.price,
                                                            fs.seat_type,
                                                            fs.Type_seatCount,
                                                            fs.Type_seatCost,
                                                            fs.Crew_Id
                                                         //  , fs.economy_seatCount
            }));

            return table;

        }

        public static FlightSchedule construct(List<object> list)
        {
            FlightSchedule flightSchedule = new FlightSchedule();
            flightSchedule.FlightScheduleID = (int)list[0];
            flightSchedule.FlightName = list[1].ToString();
            flightSchedule.FlightCarrier = list[2].ToString();
            flightSchedule.FlightNumberOfSeats = (int)list[3];
            flightSchedule.FlighFrom = list[4].ToString();
            flightSchedule.FlightTo = list[5].ToString();
            flightSchedule.FlightDepartureTime = (DateTime)list[6];
            flightSchedule.FlightArrival = (DateTime)list[7];
            flightSchedule.FlightDuration = (float)list[8];
            flightSchedule.FlightID = (int)list[9];
            //    flightSchedule.price = (float)list[10];
            flightSchedule.seat_type = list[10].ToString();
            flightSchedule.Type_seatCount = (int)list[11];
            // flightSchedule.Type_seatCost = (float)list[12];
            //     flightSchedule.economy_seatCount = (int)list[12];
            flightSchedule.Crew_Id = (int)list[12];

            return flightSchedule;
        }
    }
}
