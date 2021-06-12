using System;

namespace Hyked.API.Models.Response
{
    public class CarMetaDto
    {
        public int Id { get; set; }

        public string Manufacturer { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public string Color { get; set; }

        public int PassengerSeats { get; set; }

        public DateTimeOffset LastModifiedUtc { get; set; }
    }
}
