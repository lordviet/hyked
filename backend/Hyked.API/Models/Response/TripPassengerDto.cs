namespace Hyked.API.Models.Response
{
    public class TripPassengerDto
    {
        public int Id { get; set; }

        public TripDto Trip { get; set; }

        public UserDto Passenger { get; set; }
    }
}
