using System;
using System.Collections.Generic;

namespace Hyked.API.Models.Response
{
    public class UserDto
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string ApiKey { get; set; }

        public CarMetaDto Car { get; set; }
    }
}
