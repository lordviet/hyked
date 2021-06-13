using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Hyked.API.Services.Contracts;
using Hyked.API.Models.Request;
using System.ComponentModel.DataAnnotations;
using Hyked.API.Entities;
using System.Text;
using System.Security.Cryptography;

namespace Hyked.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IHykedRepository repository;
        private readonly IMapper mapper;

        public UsersController(IHykedRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        [HttpGet("login")]
        public IActionResult Login([Required] string username, [Required] string password)
        {
            string encryptedPass = ComputeSha256Hash(password);

            User user = this.repository.GetUser(username, encryptedPass);

            if (user == null)
            {
                return this.NotFound();
            }

            return this.Content($"API-KEY-{ComputeSha256Hash($"{username}{encryptedPass}")}");
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody, Required] UserRequestDto userRequest)
        {
            string username = userRequest.Username;

            if (this.repository.UserExists(username))
            {
                return this.Problem($"Username {username} is taken.");
            }

            string encryptedPass = ComputeSha256Hash(userRequest.Password);

            userRequest.Password = encryptedPass;

            User user = this.mapper.Map<User>(userRequest);

            this.repository.RegisterUser(user);

            this.repository.AddLog(new Audit
            {
                TableName = "Users",
                Operation = "INSERT"
            });

            this.repository.Save();

            return this.Content($"API-KEY-{ComputeSha256Hash($"{user.Username}{encryptedPass}")}");
        }

        #region Helpers
        private static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        #endregion
    }
}
