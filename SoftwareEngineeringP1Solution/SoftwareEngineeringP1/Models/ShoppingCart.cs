using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftwareEngineeringP1.Models
{
    public class ShoppingCart
    {
        public int UserId { get;  set; }
        public int FlightId { get; set; }
        public Airport SourceAirport { get; internal set; }
        public Airport DestinationAirport { get; internal set; }
        public int SourceAirportId { get; internal set; }
        public int DestinationAirportId { get; internal set; }
        public double Price { get; internal set; }
        public bool Status { get; internal set; }
        public DateTime DepartureTime { get; internal set; }
        public DateTime ArrivalTime { get; internal set; }
        public int Name { get; internal set; }
    }
}