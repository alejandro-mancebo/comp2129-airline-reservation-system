using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DataAccess
{
    public class Connection
    {

        //private static string connectionString =
        //    @"Data Source=(LocalDB)\MSSQLLocalDB;" +
        //    @"AttachDbFilename=|DataDirectory|\Database\AirlineReservationDB1.mdf;" +
        //    @"Integrated Security=True;" +
        //    @"Connect Timeout=30";

        // C:\AirlineReservation\DataAccess\Database
        // private static string fileFullPath = @"C:\AirlineReservation\DataAccess\Database\AirlineReservationDB1.mdf;";
        // private static string fileFullPath = @"C:\AirlineReservation";

        //private static string fileFullPath = Directory.GetCurrentDirectory(); 

        private static string connectionString = ConfigurationManager.ConnectionStrings["AirlineReservationDBConnectionString"].ConnectionString;

        //private static string connectionString =
        //    @"Data Source=(LocalDB)\MSSQLLocalDB;" +          
        //    $@"AttachDbFilename={fileFullPath}\Database\AirlineReservationDB1.mdf;" +
        //    @"Integrated Security=True;" +
        //    @"Connect Timeout=30";
        

         private SqlConnection connection = new SqlConnection(connectionString);


        public SqlConnection OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            return connection;
        }


        public SqlConnection CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
            return connection;
        }
    }
}
