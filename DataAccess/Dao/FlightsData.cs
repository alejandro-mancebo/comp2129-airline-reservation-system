using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Entities;
using DataAccess.Procedures;

namespace DataAccess
{
    public class FlightsData
    {
        private Connection connection; 

        DataTable table; 
        SqlCommand command; 

        SqlDataReader reader;


        public FlightsData()
        {
            connection = new Connection();
            table = new DataTable();
            command = new SqlCommand();
        }


        public DataTable Show()
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = FlightProcedures.ShowFlights;
            command.CommandType = CommandType.Text;
            reader = command.ExecuteReader();
            table.Load(reader);
            connection.CloseConnection();

            return table;
        }


        public DataTable Show(string flightDestination, int numberPassengers)
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = FlightProcedures.ShowFlightsByDestination;
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@destination", flightDestination);
            command.Parameters.AddWithValue("@numberPassengers", numberPassengers);
            reader = command.ExecuteReader();

            table.Load(reader); command.Parameters.Clear();
            connection.CloseConnection();

            return table;
        }


        public Flight GetFlight(string id)
        {

            command.Connection = connection.OpenConnection();
            command.CommandText = FlightProcedures.SelectFlight;
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@idPK", id);
            reader = command.ExecuteReader();

            reader.Read();

            Flight flight = new Flight();

            flight.flightNumber = reader["flightNumberID"].ToString();
            flight.origin = reader["origin"].ToString();
            flight.destination = reader["destination"].ToString();
            flight.capacity = Convert.ToInt16(reader["capacity"].ToString());
            flight.numberPassengers = Convert.ToInt16(reader["numberPassengers"].ToString());
            flight.price = Convert.ToDouble(reader["price"].ToString());
            flight.flightDate = Convert.ToDateTime(reader["flightDate"].ToString());
            flight.flightTime = Convert.ToDateTime(reader["flightTime"].ToString());
            flight.duration = Convert.ToDateTime(reader["duration"].ToString());

            command.Parameters.Clear();
            connection.CloseConnection();

            return flight;
        }


        public DataTable FlightDestinationList()
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = FlightProcedures.FlightDestinationList;
            command.CommandType = CommandType.Text;
            reader = command.ExecuteReader();

            table.Load(reader);
            connection.CloseConnection();

            return table;
        }


        public void Insert(string flightNumber,
                            string origin,
                            string destination,
                            int capacity,
                            //int numberPassengers,
                            decimal price,
                            DateTime flightDate,
                            DateTime flightTime,
                            DateTime duration)
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = FlightProcedures.InsertFlight;
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@FlightNumber", flightNumber);
            command.Parameters.AddWithValue("@Origin", origin);
            command.Parameters.AddWithValue("@Destination", destination);
            command.Parameters.AddWithValue("@Capacity", capacity);
            //command.Parameters.AddWithValue("@NumberPassengers", numberPassengers);
            command.Parameters.AddWithValue("@Price", price);
            command.Parameters.AddWithValue("@FlightDate", flightDate);
            command.Parameters.AddWithValue("@FlightTime", flightTime);
            command.Parameters.AddWithValue("@Duration", duration);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.CloseConnection();
        }


        public void Update(string flightNumber,
                           string origin,
                           string destination,
                           int capacity,
                           decimal price,
                           DateTime flightDate,
                           DateTime flightTime,
                           DateTime duration)
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = FlightProcedures.UpdateFlight;
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@FlightNumber", flightNumber);
            command.Parameters.AddWithValue("@Origin", origin);
            command.Parameters.AddWithValue("@Destination", destination);
            command.Parameters.AddWithValue("@Capacity", capacity);
            command.Parameters.AddWithValue("@Price", price);
            command.Parameters.AddWithValue("@FlightDate", flightDate);
            command.Parameters.AddWithValue("@FlightTime", flightTime);
            command.Parameters.AddWithValue("@Duration", duration);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.CloseConnection();
        }


        public void UpdateNumberPassagengers(string flightNumber, int numberPassengers)
        {
            command.Connection = connection.OpenConnection();
            command.CommandText = FlightProcedures.UpdateNumberPassengers;
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@flightNumberID", flightNumber);
            command.Parameters.AddWithValue("@numberPassengers", numberPassengers);
            command.ExecuteNonQuery();
            command.Parameters.Clear();
            connection.CloseConnection();
        }
    }
}
