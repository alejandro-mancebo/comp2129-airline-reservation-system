using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Flight
    {
        public string flightNumber { get; set; }
        public string origin { get; set; }
        public string destination { get; set; }
        public int capacity { get; set; }
        public int numberPassengers { get; set; }
        public double price { get; set; }
        public DateTime flightDate { get; set; }
        public DateTime flightTime { get; set; }
        public DateTime duration { get; set; }
    }
}
