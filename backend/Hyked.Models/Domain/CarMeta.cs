using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hyked.Models.Domain
{
    public class CarMeta
    {
        [Key]
        [Column]
        public int Id { get; set; }

        [Column]
        public string Manufacturer { get; set; }

        [Column]
        public string Model { get; set; }

        [Column]
        public int Year { get; set; }

        [Column]
        public string Color { get; set; }

        [Column]
        public int PassengerSeats { get; set; }
    }
}
