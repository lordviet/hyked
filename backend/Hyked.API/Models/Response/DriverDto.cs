namespace Hyked.API.Models.Response
{
    public class DriverDto
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string PhoneNumber { get; set; }

        public CarMetaDto Car { get; set; }
    }
}
