using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hyked.API.Entities
{
    public class TripPassenger
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("TripId")]
        public Trip Trip { get; set; }

        public int TripId { get; set; }
        
        [ForeignKey("UserId")]
        public User Passenger { get; set; }

        public int UserId { get; set; }

        [Required]
        public DateTimeOffset LastModifiedUtc { get; set; } = DateTimeOffset.UtcNow;

    }
}
