using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Booking
    {   public int id { get; set; }
        public DateTime bookingDate { get; set; }
        public int numberTickets { get; set; }
        public double amount { get; set; }
        public int customerID { get; set; }
        public string flightID { get; set; }
    }
}
