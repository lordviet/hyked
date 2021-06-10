using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hyked.Models.Domain
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column]
        public int Id { get; set; }

        [Column]
        public string Username { get; set; }

        [Column]
        public string Password { get; set; }

        [Column]
        public string PhoneNumber { get; set; }

        //[Column]
        //public string? CarId { get; set; }

        ////[LinqMapping.Association(ThisKey = "CarId", OtherKey = "Id")]

        //[Column]
        //public CarMeta Car { get; set; }

    }
}
