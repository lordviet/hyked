using System;

namespace Hyked.Rest.ResponseModels
{
    public class Trip
    {
        public string From { get; set; }

        public string To { get; set; }

        public double Price { get; set; }

        public DateTime DepartureTimeUtc { get; set; }

        public CarMeta Car { get; set; }

        public int AvailableSeats { get; set; }

        public int TakenSeats { get; set; }

        public bool IsActive { get; set; }
    }
}
