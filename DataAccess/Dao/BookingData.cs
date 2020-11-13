using DataAccess.Entities;
using DataAccess.Procedures;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess
{
    public class BookingData
    {

        private Connection connection; 

        SqlDataReader reader;
        DataTable table; 
        SqlCommand command; 
        Booking booking; 


        public BookingData()
        {
            connection = new Connection();
            table = new DataTable();
            command = new SqlCommand();
            booking = new Booking();
        }


        public DataTable Show()
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = BookingProcedures.ShowBooking;
            command.CommandType = CommandType.Text;
            reader = command.ExecuteReader();
            table.Load(reader);
            connection.CloseConnection();

            return table;
        }


        public Booking GetBooking(int id)
        {

            command.Connection = connection.OpenConnection();
            command.CommandText = BookingProcedures.SelectBooking;
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@idPk", id);

            reader = command.ExecuteReader();
            reader.Read();

            booking.id = Convert.ToInt32(reader["id"]);
            booking.bookingDate = Convert.ToDateTime( reader["bookingDate"].ToString());
            booking.numberTickets = Convert.ToInt16( reader["numberTickets"].ToString());
            booking.amount = Convert.ToDouble( reader["amount"].ToString());
            booking.customerID = Convert.ToInt16( reader["customerID"].ToString());
            booking.flightID = reader["flightID"].ToString();            
            command.Parameters.Clear();
            connection.CloseConnection();

            return booking;
        }


        public DataTable ShowByCustomer(int id)
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = BookingProcedures.ShowBookingByCustomer;
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@idPk", id);
            reader = command.ExecuteReader();
            table.Load(reader);
            command.Parameters.Clear();
            connection.CloseConnection();

            return table;
        }


        public void Insert(int numberTickets,
                            double amount,
                            int customerID,
                            string flightId)
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = BookingProcedures.InsertBooking;
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@bookingDate", DateTime.Now);
            command.Parameters.AddWithValue("@numberTickets", numberTickets);
            command.Parameters.AddWithValue("@amount", amount);
            command.Parameters.AddWithValue("@customerID", customerID);
            command.Parameters.AddWithValue("@flightId", flightId);

            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.CloseConnection();
        }


        public void Cancel(int id)
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = BookingProcedures.CancelBooking;
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@isCanceled", 1);           
            command.Parameters.AddWithValue("@idPK", id);

            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.CloseConnection();
        }

    }
}
