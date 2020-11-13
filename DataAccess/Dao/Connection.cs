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


                                               //   C:\Users\aleja\OneDrive\Colleges\George Brown\semester 3 - 2018 fall\COMP 2129 Advanced Object Oriented Programming\project 3\AirlineReservation\DataAccess\Database
        // private static string fileFullPath = @"C:\Users\aleja\OneDrive\Colleges\George Brown\semester 3 - 2018 fall\COMP 2129 Advanced Object Oriented Programming\project 3\AirlineReservation\DataAccess\Database\AirlineReservationDB1.mdf;";
        //private static string fileFullPath = @"C:\Users\aleja\OneDrive\_projects-for-employment\3-comp2129-p3-airline-reservation-system\AirlineReservation";

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
