using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Procedures
{
    public static class FlightProcedures
    {


        public static string SelectFlight = "SELECT " +
            "FlightNumberID, " +
            "Origin, " +
            "Destination, " +
            "Capacity, " +
            "NumberPassengers, " +
            "Price, " +
            "FlightDate, " +
            "FlightTime, " +
            "Duration " +
            "FROM Flights " +
            "WHERE FlightNumberID LIKE @idPK;";


        public static string ShowFlightsOLD = "SELECT " +
           "FlightNumberID AS Flight, " +
           "Origin, " +
           "Destination, " +
           "Capacity, " +
           "NumberPassengers AS Passengers, " +
           "Price, " +
           "FORMAT(FlightDate, 'ddd MMM dd, yyyy') AS 'Date', " +
           "FORMAT(FlightTime, 'hh:mm tt')  AS 'Time', " +
           "FORMAT(Duration, N'h\\:mm') AS Duration " +
           "FROM Flights;";


        public static string ShowFlights = "SELECT " +
            "f.FlightNumberID AS Flight, " +
            "f.Origin, " +
            "f.Destination, " +
            "f.Capacity, " +
            "np.Passengers, " +
            "FORMAT(f.Price, 'C') AS Price, " +
            "FORMAT(f.FlightDate, 'ddd MMM dd, yyyy') AS 'Date', " +
            "FORMAT(f.FlightTime, 'hh:mm tt') AS 'Time', " +
            "FORMAT(f.Duration, N'h\\:mm') AS Duration " +
            "FROM Flights AS f " +
            "LEFT JOIN ( " +
                "SELECT FlightID, SUM(NumberTickets) AS Passengers " +
                "FROM Booking WHERE IsCanceled = 0 " +
                "GROUP BY FlightID) AS np " +
            "ON np.FlightID = f.FlightNumberID";


        public static string UpdateFlight = "UPDATE Flights SET " +
            "Origin = @Origin, " +
            "Destination = @Destination, " +
            "Capacity = @Capacity, " +
            "Price = @Price, " +
            "FlightDate = @FlightDate, " +
            "FlightTime = @FlightTime, " +
            "Duration = @Duration " +
            "WHERE FlightNumberID LIKE @FlightNumber;";


        public static string ShowFlightsByDestinationOLD = "SELECT	" +
            "FlightNumberID AS Flight, " +
            "Origin, " +
            "Destination, " +
            "Capacity, " +
            "NumberPassengers AS Passengers, " +
            "Price, " +
            "FlightDate AS 'Date', " +
            "FlightTime AS 'Time', " +
            "Duration " +
            "FROM Flights " +
            "WHERE Destination like @destination AND Capacity >= @numberPassengers ;";


         public static string ShowFlightsByDestination = "SELECT " +
            "f.FlightNumberID AS Flight, " +
            "f.Origin, " +
            "f.Destination, " +
            "f.Capacity, " +
            "np.Passengers, " +
            "f.Price, " +
            "FORMAT(f.FlightDate, 'ddd MMM dd, yyyy') AS 'Date', " +
            "FORMAT(f.FlightTime, 'hh:mm tt') AS 'Time', " +
            "FORMAT(f.Duration, N'h\\:mm') AS Duration " +
            "FROM Flights AS f " +
            "LEFT JOIN ( " +
                "SELECT FlightID, SUM(NumberTickets) AS Passengers " +
                "FROM Booking WHERE IsCanceled = 0 " +
                "GROUP BY FlightID) AS np " +
            "ON np.FlightID = f.FlightNumberID " +
            "WHERE f.Destination like @destination AND f.Capacity >= @numberPassengers ;";


        public static string FlightDestinationList = "SELECT DISTINCT Destination FROM Flights;";


        public static string InsertFlight = "INSERT INTO Flights VALUES ( " +
            "@FlightNumber, "+
            "@Origin, " +
            "@Destination, " +
            "@Capacity, " +           
            "@Price, " +
            "@FlightDate," +
            "@FlightTime, " +
            "@Duration );";


        public static string UpdateNumberPassengers = "UPDATE Flights SET " +
            "numberPassengers = numberPassengers + @numberPassengers " +
            "WHERE FlightNumberID = @flightNumberID;";
            
    }
}
