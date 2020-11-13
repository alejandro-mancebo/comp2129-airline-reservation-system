using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataAccess.Entities;

namespace Domain
{
    public class FlightsModel
    {
        private string flightNumber;
        private string origin;
        private string destination;
        private int capacity;
        private int numberPassengers;
        private double price;
        private DateTime flightDate;
        private DateTime flightTime;
        private DateTime duration;

        private FlightsData flightData ;


        public string FlightNumber { get => flightNumber; set => flightNumber = value; }
        public string Origin { get => origin; set => origin = value; }
        public string Destination { get => destination; set => destination = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public int NumberPassengers { get => numberPassengers; set => numberPassengers = value; }
        public double Price { get => price; set => price = value; }
        public DateTime FlightDate { get => flightDate; set => flightDate = value; }
        public DateTime FlightTime { get => flightTime; set => flightTime = value; }
        public DateTime Duration { get => duration; set => duration = value; }


        public FlightsModel ()
        {
            flightData = new FlightsData();
        }


        public void GetFlight(string id)
        {
            Flight flight = new Flight();           
            flight = flightData.GetFlight(id);

            FlightNumber = flight.flightNumber;
            Origin = flight.origin;
            Destination = flight.destination;
            Capacity = flight.capacity;
            NumberPassengers = flight.numberPassengers;
            Price = flight.price;
            FlightDate = flight.flightDate;
            FlightTime = flight.flightTime;
            Duration = flight.duration;
        }


        public DataTable ShowFlights()
        {
            DataTable table = new DataTable();
            table = flightData.Show();

            return table;
        }


        public DataTable ShowFlights(string flightDestination, string numberPassenger)
        {
            DataTable table = new DataTable();
            table = flightData.Show(flightDestination, Convert.ToInt16(numberPassenger));

            return table;
        }


        public DataTable FlightDestinationList()
        {
            DataTable table = new DataTable();
            table = flightData.FlightDestinationList();

            return table;
        }


        public void InsertFlight(string flightNumber,
                                  string origin,
                                  string destination,
                                  string capacity,
                                  string price,
                                  string flightDate,
                                  string flightTime,
                                  string duration)
        {
            flightData.Insert(flightNumber,
                              origin,
                              destination,
                              Convert.ToInt16(capacity),
                              Convert.ToDecimal(price),
                              Convert.ToDateTime(flightDate),
                              Convert.ToDateTime(flightTime),
                              Convert.ToDateTime(duration));
        }

  
        public void EditFlight(string flightNumber,
                               string origin,
                               string destination,
                               string capacity,                             
                               string price,
                               string flightDate,
                               string flightTime,
                               string duration)
        {
            flightData.Update(flightNumber,
                              origin,
                              destination,
                              Convert.ToInt16(capacity),                             
                              Convert.ToDecimal(price),
                              Convert.ToDateTime(flightDate),
                              Convert.ToDateTime(flightTime),
                              Convert.ToDateTime(duration));
        }
               
    }
}
