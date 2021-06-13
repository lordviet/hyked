using System;
using System.Collections.Generic;

namespace Hyked.API.Models.Response
{
    public class UserDto
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string PhoneNumber { get; set; }

        public CarMetaDto Car { get; set; }
                
        public ICollection<TripDto> Trips { get; set; } = new List<TripDto>();

        public DateTimeOffset LastModifiedUtc17114131 { get; set; }
    }
}
