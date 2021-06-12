using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hyked.API.Entities
{
    public class Audit
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string TableName { get; set; }

        [Required]
        public string Operation { get; set; }

        public DateTimeOffset TimeOfOperationUtc { get; set; } = DateTime.UtcNow;
    }
}
