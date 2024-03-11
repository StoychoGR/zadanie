using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ConsoleApp1.Data
{
    public class Database
    {
        private static string ConnectionString = "Data Source = DESKTOP-1K6UES3; Database = Levaki2; integreated security =  true";
        public static SqlConnection GetConnection()
        {
        return new SqlConnection(ConnectionString);
        }
    }
}
