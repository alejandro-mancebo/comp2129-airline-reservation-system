using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Procedures
{
    public static class BookingProcedures
    {
        public static string SelectBooking = "SELECT " +
            "Id, " +
            "BookingDate, " +
            "NumberTickets, " +
            "Amount, " +
            "CustomerID, " +
            "FlightID " +                    
            "FROM Booking " +
            "WHERE Id LIKE @idPk;";


		public static string ShowBooking = "SELECT " +
			"b.Id, " +
			"p.Id AS 'Cust. ID', " +
			"CONCAT(p.FirstName, ' ', p.LastName) AS Name, " +
			"b.BookingDate AS Booking, " +
			"f.FlightNumberID AS Flight, " +
			"f.Origin, " +
			"f.Destination, " +
			"f.FlightDate AS 'Date', " +
			"FORMAT(f.FlightTime, N'hh:mm tt') AS 'Time', " +
			"FORMAT(f.Duration, N'h\\:mm') AS Duration, " +
			"f.Price, " +
			"b.NumberTickets AS Tickets, " +
			"b.Amount, " +
			"b.IsCanceled " +
			"FROM Booking AS b " +
			"INNER JOIN Persons AS p " +
			"ON b.CustomerID = p.Id " +
			"INNER JOIN Flights AS f " +
			"ON b.FlightID = f.FlightNumberID ;";


		public static string ShowBookingByCustomer = "SELECT " +
			"f.FlightNumberID AS Flight, " +
			"f.Destination, " +
			"f.FlightDate AS 'Date', " +
			"f.FlightTime AS 'Time', " +
			"f.Price, " +
			"b.NumberTickets AS Tickets, " +
			"b.Amount " +
			"FROM Booking AS b " +
			"INNER JOIN Persons AS p " +
			"ON b.CustomerID = p.Id " +
			"INNER JOIN Flights AS f " +
			"ON b.FlightID = f.FlightNumberID " +
			"WHERE p.Id = @idPK ;";


		public static string InsertBooking = "INSERT INTO Booking VALUES " +
			"( @BookingDate, " +
			"@numberTickets, " +
			"@amount, " +
			"@customerID, " +
			"@flightID, " +
			"0 );";


		public static string CancelBooking = "UPDATE Booking SET " +
			"IsCanceled = @isCanceled " +
			"WHERE Id = @idPK;";

	}
}
