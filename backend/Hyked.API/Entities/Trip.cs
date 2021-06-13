using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hyked.API.Entities
{
    public class Trip
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [ForeignKey("UserId")]
        public User Driver { get; set; }

        public int UserId { get; set; }

        [Required]
        public string FromLocation { get; set; }

        [Required]
        public string ToLocation { get; set; }

        [Required]
        [Range(0, 1000)]
        public double Price { get; set; }

        [Required]
        public DateTimeOffset DepartureTimeUtc { get; set; }

        [Required]
        [Range(1, 10)]
        public int AvailableSeats { get; set; }
        
        public ICollection<TripPassenger> Passengers { get; set; } = new List<TripPassenger>();

        [Required]
        public bool IsActive { get; set; } = true;

        [Required]
        public DateTimeOffset LastModifiedUtc { get; set; } = DateTimeOffset.UtcNow;
    }
}
