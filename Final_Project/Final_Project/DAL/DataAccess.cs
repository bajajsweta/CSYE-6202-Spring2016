using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using MySql.Data.MySqlClient;
using System.Data;
using Final_Project.DAO;

namespace Final_Project.DAL
{
    public class DataAccess
    {

        public String GetValue(String val)
        {
            if (val != null && !val.Trim().Equals(""))
                return val;

            return null;
        }


        public DataTable GetDataTableFor(List<List<object>> data)
        {
            DataTable table = new DataTable();

            if (data.Count == 0)
                return table;

            data[0].ForEach(d => table.Columns.Add());
            data.ForEach(d => table.Rows.Add(d.ToArray()));

            return table;
        }


        public List<List<object>> runProcedure(string storedProcedureName, List<string> argumentValues, List<string> argumentTypes)
        {
            string sql = "call airplane." + storedProcedureName + " (";

            for (int i = 0; i < argumentValues.Count; ++i)
            {

                if(argumentValues[i] == null)
                {
                    sql += "NULL";
                }
                else
                {
                    switch (argumentTypes[i])
                    {
                        case "string":
                            sql += "'" + argumentValues[i] + "' ";
                            break;
                        case "datetime":
                            sql += "'" + argumentValues[i] + "' ";
                            break;
                        case "int":
                            sql += argumentValues[i] + " ";
                            break;

                        case "float":
                            sql += argumentValues[i] + " ";
                            break;
                    }
                }
                
                if (i != argumentValues.Count - 1)
                    sql += ",";
            }

            sql += ")";
            string MyConnection = "datasource=localhost;port=3306;username=root;password=sweta2305";
            MySqlConnection connection = new MySqlConnection(MyConnection);
            MySqlCommand command = new MySqlCommand(sql, connection);

            MySqlDataReader MyReader;
            connection.Open();

            MyReader = command.ExecuteReader();
            List<List<object>> data = new List<List<object>>();

            while (MyReader.Read())
            {
                object[] row = new object[MyReader.VisibleFieldCount];
                MyReader.GetValues(row);
                data.Add(row.ToList());
            }

            connection.Close();


            return data;
        }
    }
}
