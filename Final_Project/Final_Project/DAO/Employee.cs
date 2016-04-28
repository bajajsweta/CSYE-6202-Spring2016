using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DAO
{
    public class Employee : Person
    {

        public string Designation { get; set; }
        public int crew_id { get; set; }

        public static DataTable GetDataTable(List<Employee> list)
        {
            DataTable table = new DataTable();

            if (list.Count == 0)
                return table;


            table.Columns.Add(new DataColumn("Employee"));
            table.Columns.Add(new DataColumn("Employee Name"));
            table.Columns.Add(new DataColumn("Employee Designation"));
            table.Columns.Add(new DataColumn("Employee Age"));
            table.Columns.Add(new DataColumn("Employee Gender"));
            table.Columns.Add(new DataColumn("Employee Email"));
            table.Columns.Add(new DataColumn("Employee Password"));
            table.Columns.Add(new DataColumn("Employee Crew ID"));



            list.ForEach(e => table.Rows.Add(new object[]{  e,
                                                            e.Name,
                                                            e.Designation,
                                                            e.Age,
                                                            e.Gender,
                                                            e.Email,
                                                            e.Password,
                                                            e.crew_id
                                                         }));
            return table;

        }

        public static Employee construct(List<object> list)
        {
            Employee employee = new Employee();
            employee.ID = (int)list[0];
            employee.Name = list[1].ToString();
            employee.Designation = list[2].ToString();
            employee.Age = (int)list[3];
            employee.Gender = list[4].ToString();
            employee.Email = list[5].ToString();
            employee.Password = list[6].ToString();
            employee.crew_id = (int)list[7];
            return employee;
        }
    }
}
