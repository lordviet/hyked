using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hyked.API.Entities
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        public CarMeta Car { get; set; }

        public ICollection<Trip> Trips { get; set; } = new List<Trip>();

        [Required]
        public DateTimeOffset LastModifiedUtc { get; set; }
    }
}
