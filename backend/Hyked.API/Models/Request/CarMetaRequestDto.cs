using System;
using System.ComponentModel.DataAnnotations;

namespace Hyked.API.Models.Request
{
    public class CarMetaRequestDto
    {
        [Required(ErrorMessage = "You should provide a car manufacturer.")]
        [MaxLength(50)]
        public string Manufacturer { get; set; }

        [Required(ErrorMessage = "You should provide a car model.")]
        [MaxLength(100)]
        public string Model { get; set; }

        [Required(ErrorMessage = "You should provide a car year.")]
        [Range(1886, 2021)]
        public int Year { get; set; }

        [Required(ErrorMessage = "You should provide a car color.")]
        [MaxLength(20)]
        public string Color { get; set; }

        [Required(ErrorMessage = "You should provide number of passenger seats")]
        [Range(1, 20)]
        public int PassengerSeats { get; set; }

    }
}
