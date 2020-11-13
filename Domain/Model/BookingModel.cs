using DataAccess;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class BookingModel
    {
        private int id;
        private DateTime bookingDate;
        private int numberTickets;
        private double amount;
        private int customerID;
        private string flightID;

        private BookingData bookingData ;

        public int Id { get => id; set => id = value; }
        public DateTime BookingDate { get => bookingDate; set => bookingDate = value; }
        public int NumberTickets { get => numberTickets; set => numberTickets = value; }
        public double Amount { get => amount; set => amount = value; }
        public int CustomerID { get => customerID; set => customerID = value; }
        public string FlightID { get => flightID; set => flightID = value; }


        public BookingModel()
        {
            bookingData = new BookingData();
        }


        public void GetBooking(string id)
        {
            Booking booking = new Booking();

            booking = bookingData.GetBooking(Convert.ToInt32(id));

            Id = booking.id;
            BookingDate = booking.bookingDate;
            NumberTickets = booking.numberTickets;
            Amount = booking.amount;
            CustomerID = booking.customerID;
            FlightID = booking.flightID;
        }


        public DataTable Show()
        {
            DataTable table = bookingData.Show();
            return table;
        }


        public DataTable ShowByCustomer(string id)
        {
            DataTable table = bookingData.ShowByCustomer(Convert.ToInt32(id));
            return table;
        }


        public void InsertBooking(string numberTickets,
                                  string amount,
                                  string customerID,
                                  string flightId)
        {
            bookingData.Insert(Convert.ToInt16(numberTickets), 
                               Convert.ToDouble(amount),
                               Convert.ToInt32(customerID),
                               flightId);
        }


        public void CancelBooking(string id)
        {
            bookingData.Cancel( Convert.ToInt32(id));
        }

    }
}
