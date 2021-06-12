using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hyked.API.Entities
{
    public class CarMeta
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("UserId")]        
        public User Owner { get; set; }

        public int UserId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Manufacturer { get; set; }

        [Required]
        [MaxLength(100)]
        public string Model { get; set; }

        [Required]
        [Range(1886, 2021)]
        public int Year { get; set; }

        [Required]
        [MaxLength(20)]
        public string Color { get; set; }

        [Required]
        [Range(1, 20)]
        public int PassengerSeats { get; set; }

        [Required]
        public DateTimeOffset LastModifiedUtc { get; set; }
    }
}
