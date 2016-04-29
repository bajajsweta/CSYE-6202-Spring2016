using Final_Project.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DAL
{
    class FlightScheduleDataAccess : DataAccess
    {
        public List<FlightSchedule> SearchFlightSchedule(FlightSchedule flightSchedule)
        {
            var paramValues = new List<string>();
            paramValues.Add(flightSchedule != null ? GetValue(flightSchedule.FlighFrom)  : null);
            paramValues.Add(flightSchedule != null ? GetValue(flightSchedule.FlightTo) : null);
            paramValues.Add(flightSchedule != null ? GetValue(flightSchedule.FlightDepartureTime.ToString("yyyy-MM-dd")) : null);
            paramValues.Add(flightSchedule != null ? flightSchedule.FlightNumberOfSeats.ToString() : null);
            paramValues.Add(flightSchedule != null ? GetValue(flightSchedule.seat_type) : null);

            var paramTypes = new List<string>();
            paramTypes.Add("string");
            paramTypes.Add("string");
            paramTypes.Add("datetime");
            paramTypes.Add("int");
            paramTypes.Add("string");

            //    var CommonFligthDetailslist = runProcedure("trip", paramValues, paramTypes);
            var CommonFligthDetailslist = runProcedure("TRIP_LIST", paramValues, paramTypes);

            return CommonFligthDetailslist.ConvertAll(l => FlightSchedule.construct(l));
        }

             public List<FlightSchedule> GetFlightScheduleID(int flightScheduleID)
            {
            var paramValues = new List<string>();
            paramValues.Add(flightScheduleID.ToString());
         

            var paramTypes = new List<string>();
            paramTypes.Add("int");
        
            var flightchedule = runProcedure("getFlightScheduleForId", paramValues, paramTypes);

            return flightchedule.ConvertAll(l => FlightSchedule.construct(l));
        }


        public List<FlightSchedule> GetAllflightFromList()
        {
            var paramValues = new List<string>();
            var paramTypes = new List<string>();

            var flight_fromfill = runProcedure("FlightFromProc", paramValues, paramTypes);

            return flight_fromfill.ConvertAll(l => 
            {
                FlightSchedule fs = new FlightSchedule();
                fs.FlighFrom = l[0].ToString();
                return fs;
            });
        }


        public List<FlightSchedule> GetAllflightToList()
        {
            var paramValues = new List<string>();
            var paramTypes = new List<string>();

            var flight_tofill = runProcedure("FlightToProc", paramValues, paramTypes);

            return flight_tofill.ConvertAll(l =>
            {
                FlightSchedule fs = new FlightSchedule();
                fs.FlightTo = l[0].ToString();
                return fs;
            });
        }

        public List<FlightSchedule> GetAllSeatTypes()
        {
            var paramValues = new List<string>();
            var paramTypes = new List<string>();

            var seat_Type = runProcedure("Seats", paramValues, paramTypes);

            return seat_Type.ConvertAll(l =>
            {
                FlightSchedule fs = new FlightSchedule();
                fs.seat_type = l[0].ToString();
                return fs;
            });
        }


        public List<String> GetFlightLocations()
        {
            var paramValues = new List<string>();
            var paramTypes = new List<string>();

            var flight_location = runProcedure("LOCATION_LIST", paramValues, paramTypes);

            return flight_location.ConvertAll(l => l[0].ToString());

        }


        public FlightSchedule CreateFlightSchedule(FlightSchedule flightSchedule)
        {
            var paramValues = new List<string>();

            paramValues.Add(flightSchedule != null ? GetValue(flightSchedule.FlightName) : null);
            paramValues.Add(flightSchedule != null ? GetValue(flightSchedule.FlighFrom) : null);
            paramValues.Add(flightSchedule != null ? GetValue(flightSchedule.FlightTo) : null);
            paramValues.Add(flightSchedule != null ? GetValue(flightSchedule.FlightDepartureTime.ToString("yyyy-MM-dd hh:mm:ss")) : null);
            paramValues.Add(flightSchedule != null ? GetValue(flightSchedule.FlightArrival.ToString("yyyy-MM-dd hh:mm:ss")) : null);
            paramValues.Add(flightSchedule != null ? GetValue(flightSchedule.Type_seatCount.ToString()) : null);
            paramValues.Add(flightSchedule != null ? GetValue(flightSchedule.Crew_Id.ToString()) : null);
            //     paramValues.Add(flightSchedule != null ? GetValue(flightSchedule.business_seatCount.ToString()) : null);
            //    paramValues.Add(flightSchedule != null ? GetValue(flightSchedule.economy_seatCount.ToString()) : null);

            var paramTypes = new List<string>();
            paramTypes.Add("string");
            paramTypes.Add("string");
            paramTypes.Add("string");
            paramTypes.Add("datetime");
            paramTypes.Add("datetime");
            paramTypes.Add("int");
            paramTypes.Add("int");

            //      paramTypes.Add("int");
            //      paramTypes.Add("int");


            var CreateFlightSchedule = runProcedure("CREATE_FLIGHTSCHEDULE", paramValues, paramTypes);
            return flightSchedule;
        }

        public FlightSchedule UpdateFlightSchedule(FlightSchedule flightSchedule)
        {
            var paramValues = new List<string>();
            paramValues.Add(flightSchedule.FlightScheduleID.ToString());
            paramValues.Add(flightSchedule != null ? GetValue(flightSchedule.FlightName) : null);
            paramValues.Add(flightSchedule != null ? GetValue(flightSchedule.FlighFrom) : null);
            paramValues.Add(flightSchedule != null ? GetValue(flightSchedule.FlightTo) : null);
            paramValues.Add(flightSchedule != null ? GetValue(flightSchedule.FlightDepartureTime.ToString("yyyy-MM-dd hh:mm:ss")) : null);
            paramValues.Add(flightSchedule != null ? GetValue(flightSchedule.FlightArrival.ToString("yyyy-MM-dd hh:mm:ss")) : null);
            paramValues.Add(flightSchedule != null ? GetValue(flightSchedule.Type_seatCount.ToString()) : null);
            paramValues.Add(flightSchedule != null ? GetValue(flightSchedule.Crew_Id.ToString()) : null);

            var paramTypes = new List<string>();
            paramTypes.Add("int");
            paramTypes.Add("string");
            paramTypes.Add("string");
            paramTypes.Add("string");
            paramTypes.Add("datetime");
            paramTypes.Add("datetime");
            paramTypes.Add("int");
            paramTypes.Add("int");


            var CreateFlightSchedule = runProcedure("UPDATE_FLIGHTSCHEDULE", paramValues, paramTypes);
            return flightSchedule;
        }

        public void DeleteFlightSchedule(FlightSchedule flightSchedule)
        {
            var paramValues = new List<string>();
            paramValues.Add(flightSchedule != null ? GetValue(flightSchedule.FlightScheduleID.ToString()) : null);

            var paramTypes = new List<string>();
            paramTypes.Add("int");


            var CreateFlightSchedule = runProcedure("DELETE_FLIGHTSCHEDULE", paramValues, paramTypes);
        }

    }
}
