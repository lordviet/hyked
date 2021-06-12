using System;
using System.ComponentModel.DataAnnotations;

namespace Hyked.API.Models.Request
{
    public class TripRequestDto
    {
        [Required(ErrorMessage = "Please add a starting point for your trip.")]
        public string FromLocation { get; set; }

        [Required(ErrorMessage = "Please add a finishing point for your trip.")]
        public string ToLocation { get; set; }

        [Required(ErrorMessage = "Please add a price.")]
        [Range(0, 1000)]
        public double Price { get; set; }

        [Required(ErrorMessage = "Please add a departure time.")]
        public DateTimeOffset DepartureTimeUtc { get; set; }

        [Required(ErrorMessage = "Please add a number of available seats")]
        [Range(1, 10)]
        public int AvailableSeats { get; set; }
        
        // When a new trip is created it is automatically active with 0 taken seats
    }
}
