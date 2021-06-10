using Hyked.Data.Contracts;
using Hyked.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hyked.Web.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TripController : ControllerBase
    {
        private readonly IGenericRepository<User> userRepository;

        public TripController(IGenericRepository<User> userRepository)
        {
            this.userRepository = userRepository;
        }

        [HttpPost]
        public IActionResult RegisterUser(string username, string password)
        {
            var user = new User { Username = username, Password = password, PhoneNumber = "09890231" };

            this.userRepository.Insert(user);

            return this.Ok();
        }
    }
}
