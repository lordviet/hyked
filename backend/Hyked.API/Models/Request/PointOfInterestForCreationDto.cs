using System.ComponentModel.DataAnnotations;

namespace Hyked.API.Models
{
    public class PointOfInterestForCreationDto
    {
        // No id because the server takes care of that
        [Required(ErrorMessage = "You should provide a name value.")]
        [MaxLength(50)]
        public string Name { get; set; }
        
        [MaxLength(200)]
        public string Description { get; set; }
    }
}
