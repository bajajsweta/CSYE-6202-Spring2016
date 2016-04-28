using Final_Project.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DAL
{
    class FlightCrewDataAccess : DataAccess
    {
        public List<Employee> CrewList(Employee employee)
        {
        var paramValues = new List<string>();
            paramValues.Add(GetValue(employee.Name));
            paramValues.Add(GetValue(employee.Designation));
            paramValues.Add(employee.Age == 0 ? null : "" + employee.Age); 
            paramValues.Add(GetValue(employee.Gender));
            paramValues.Add(GetValue(employee.Email));
            paramValues.Add(GetValue(employee.Password));

            var paramTypes = new List<string>();
            paramTypes.Add("string");
            paramTypes.Add("string");
            paramTypes.Add("int");
            paramTypes.Add("string");
            paramTypes.Add("string");
            paramTypes.Add("string");

            //Enter the Stored proc for the Employee
            var CrewList = runProcedure("EMPLOYEE_LIST", paramValues, paramTypes);

            return CrewList.ConvertAll(l => Employee.construct(l));
        }


        public Employee createFlightCrew(Employee employee)
        {
            var paramValues = new List<string>();
            paramValues.Add(employee.Name);
            paramValues.Add(employee.Designation);
            paramValues.Add(Convert.ToString(employee.Age));
            paramValues.Add(employee.Gender);
            paramValues.Add(employee.Email);
            paramValues.Add(employee.Password);
            paramValues.Add(employee.crew_id.ToString());

            var paramTypes = new List<string>();
            paramTypes.Add("string");
            paramTypes.Add("string");
            paramTypes.Add("int");
            paramTypes.Add("string");
            paramTypes.Add("string");
            paramTypes.Add("string");
            paramTypes.Add("int");

            //Enter the Stored proc for the Flight
            var CreateFlightCrewLists = runProcedure("CREATE_EMPLOYEE", paramValues, paramTypes);
            employee = Employee.construct(CreateFlightCrewLists[0]);

            return employee;
        }


        public void updateFlightCrew(Employee employee)
        {

            var paramValues = new List<string>();
            paramValues.Add(Convert.ToString(employee.ID));
            paramValues.Add(employee.Name);
            paramValues.Add(employee.Designation);
            paramValues.Add(Convert.ToString(employee.Age));
            paramValues.Add(employee.Gender);
            paramValues.Add(employee.Email);
            paramValues.Add(employee.Password);
            paramValues.Add(employee.crew_id.ToString());



            var paramTypes = new List<string>();
            paramTypes.Add("int");
            paramTypes.Add("string");
            paramTypes.Add("string");
            paramTypes.Add("int");
            paramTypes.Add("string");
            paramTypes.Add("string");
            paramTypes.Add("string");
            paramTypes.Add("int");


            //Enter the Stored proc for the Flight
            var UpdateFlightCrewLists = runProcedure("UPDATE_EMPLOYEE", paramValues, paramTypes);
        }

        public void deleteFlightCrew(Employee employee)
        {

            var paramValues = new List<string>();
            paramValues.Add(Convert.ToString(employee.ID));

            var paramTypes = new List<string>();
            paramTypes.Add("int");

            var DeleteFlightLists = runProcedure("DELETE_EMPLOYEE", paramValues, paramTypes);

        }

    }
}
