using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.DAO
{
    public class Flight
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Carrier { get; set; }
        public int NumberOfSeats { get; set; }

        public static DataTable GetDataTable(List<Flight> list)
        {
            DataTable table = new DataTable();

            if (list.Count == 0)
                return table;


            table.Columns.Add(new DataColumn("Flight"));
            table.Columns.Add(new DataColumn("Flight Carrier"));
            table.Columns.Add(new DataColumn("Flight Name"));
            table.Columns.Add(new DataColumn("Flight No. Of Seats"));


            list.ForEach(f => table.Rows.Add(new object[]{  f,
                                                            f.Carrier,
                                                            f.Name,
                                                            f.NumberOfSeats
                                                         }));
            return table;

        }



        public static Flight construct(List<object> list)
        {
            if ((int)list[3] < 0)
                return null;

            Flight flight = new Flight();
            flight.Id = (int) list[0];
            flight.Name = list[1].ToString();
            flight.Carrier = list[2].ToString();
            flight.NumberOfSeats = (int) list[3];
            return flight;
        }
    }
}
