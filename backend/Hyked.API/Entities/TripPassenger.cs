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
        
        public string PassengerUsername { get; set; }

        [Required]
        public DateTimeOffset LastModifiedUtc17114131 { get; set; } = DateTimeOffset.UtcNow;
    }
}
