using Final_Project.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DAL
{
    class FlightDataAccess : DataAccess
    {

        public List<Flight> getAllFlights(Flight flight)
        {

           var paramValues = new List<string>();
            paramValues.Add(GetValue(flight.Name));
            paramValues.Add(GetValue(flight.Carrier));
            paramValues.Add(flight.NumberOfSeats == 0 ? null : "" + flight.NumberOfSeats);

            var paramTypes = new List<string>(); 
            paramTypes.Add("string");
            paramTypes.Add("string");
            paramTypes.Add("int");

            var CreateFlightList = runProcedure("FLIGHT_LIST", paramValues, paramTypes);

           return CreateFlightList.ConvertAll(l => Flight.construct(l));
        }


        public Flight createFlight(Flight flight)
        {
            var paramValues = new List<string>();
            paramValues.Add(Convert.ToString(flight.Id));
            paramValues.Add(flight.Name);
            paramValues.Add(flight.Carrier);
            paramValues.Add(Convert.ToString(flight.NumberOfSeats));

            var paramTypes = new List<string>();
            paramTypes.Add("int");
            paramTypes.Add("string");
            paramTypes.Add("string");
            paramTypes.Add("int");

            //Enter the Stored proc for the Flight
            var CreateFlightLists = runProcedure("CREATE_FLIGHT", paramValues, paramTypes);
            flight = Flight.construct(CreateFlightLists[0]);

            return flight;
        }


        public void updateFlight(Flight flight)
        {

            var paramValues = new List<string>();
            paramValues.Add(Convert.ToString(flight.Id));
            paramValues.Add(flight.Name);
            paramValues.Add(flight.Carrier);
            paramValues.Add(Convert.ToString(flight.NumberOfSeats));

            var paramTypes = new List<string>();
            paramTypes.Add("int");
            paramTypes.Add("string");
            paramTypes.Add("string");
            paramTypes.Add("int");

            //Enter the Stored proc for the Flight
            var CreateFlightLists = runProcedure("UPDATE_FLIGHT", paramValues, paramTypes);
            }

        public void deleteFlight(Flight flight)
        {

            var paramValues = new List<string>();
            paramValues.Add(Convert.ToString(flight.Id));
           
            var paramTypes = new List<string>();
            paramTypes.Add("int");

            var CreateFlightLists = runProcedure("DELETE_FLIGHT", paramValues, paramTypes);

        }

    }
}
