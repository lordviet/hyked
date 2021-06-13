using System;

namespace Hyked.API.Models.Response
{
    public class TripPassengerDto
    {
        public int Id { get; set; }

        //public TripDto Trip { get; set; }

        public string PassengerUsername { get; set; }

        public DateTimeOffset LastModifiedUtc { get; set; }
    }
}
