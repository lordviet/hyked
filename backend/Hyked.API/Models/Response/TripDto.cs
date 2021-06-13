using System;

namespace Hyked.API.Models.Response
{
    public class TripDto
    {
        public string Id { get; set; }
        
        public string FromLocation { get; set; }

        public string ToLocation { get; set; }

        public double Price { get; set; }

        public DateTimeOffset DepartureTimeUtc { get; set; }

        public int AvailableSeats { get; set; }

        public int TakenSeats { get; set; }

        public bool IsActive { get; set; }

        public DateTimeOffset LastModifiedUtc { get; set; }
    }
}
