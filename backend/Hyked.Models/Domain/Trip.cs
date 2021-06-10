using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using LinqMapping = System.Data.Linq.Mapping;


namespace Hyked.Models.Domain
{
    public class Trip
    {
        [Key]
        [Column]
        public int Id { get; set; }

        [Column]
        public int UserId { get; set; }

        //[LinqMapping.Association(ThisKey = "UserId", OtherKey = "Id")]

        [Column]
        public User User { get; set; }

        [Column]
        public string From { get; set; }

        [Column]
        public string To { get; set; }

        [Column]
        public double Price { get; set; }

        [Column]
        public DateTime DepartureTimeUtc { get; set; }

        [Column]
        public int AvailableSeats { get; set; }

        [Column]
        public int TakenSeats { get; set; }

        [Column]
        public bool IsActive { get; set; }
    }
}
