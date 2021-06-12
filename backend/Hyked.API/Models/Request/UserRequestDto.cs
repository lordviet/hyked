using System.ComponentModel.DataAnnotations;

namespace Hyked.API.Models.Request
{
    public class UserRequestDto
    {
        [Required(ErrorMessage = "Please provide a username.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please provide a password.")]        
        public string Password { get; set; }

        [Required(ErrorMessage = "Please provide a phone number.")]
        [MaxLength(15)]
        public string PhoneNumber { get; set; }
    }
}
